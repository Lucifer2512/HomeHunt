using BusinessLogicLayer.Services.Interfaces;
using BusinessLogicLayer.Types;
using DataAccessLayer.Models;
using DataAccessLayer.UnitOfWork;
using Net.payOS;
using Net.payOS.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction = DataAccessLayer.Models.Transaction;

namespace BusinessLogicLayer.Services.Implements
{
    public class TransactionService : ITransactionService
    {
        private readonly PayOS _payOS;
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(PayOS payOS, IUnitOfWork unitOfWork)
        {
            _payOS = payOS;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> CreatePaymentLink(CreatePaymentLinkRequest body, string Phone)
        {
            try
            {
                var user = await _unitOfWork.Repository<User>().FindAsync(u => u.Email == Phone);
                if (user == null)
                {
                    return new Response(-1, "User not found", null);
                }

                int orderCode = int.Parse(DateTimeOffset.Now.ToString("ffffff"));

                ItemData item = new ItemData(body.productName, 1, body.price);
                List<ItemData> items = new List<ItemData> { item };

                string buyerName = !string.IsNullOrEmpty(body.buyerName) ? body.buyerName : user.FullName;
                string buyerPhone = !string.IsNullOrEmpty(body.buyerPhone) ? body.buyerPhone : Phone;

                PaymentData paymentData = new PaymentData(
                    orderCode,
                    body.price,
                    body.description,
                    items,
                    body.cancelUrl,
                    body.returnUrl,
                    buyerName,
                    buyerPhone
                );

                CreatePaymentResult createPayment = await _payOS.createPaymentLink(paymentData);

                var paymentTransaction = new Transaction
                {
                    TransactionCode = orderCode,
                    UserId = user.Id,
                    Price = body.price,
                    Status = null,
                };

                await _unitOfWork.Repository<Transaction>().InsertAsync(paymentTransaction);
                await _unitOfWork.CommitAsync();

                var currentUserInfo = new
                {
                    user.Id,
                    user.FullName,
                    user.PhoneNumber,
                };

                return new Response(0, "success", new
                {
                    paymentInfo = createPayment,
                    userInfo = currentUserInfo
                });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return new Response(-1, "fail", null);
            }
        }


        public async Task<Response> GetOrder(int orderCode)
        {
            try
            {
                PaymentLinkInformation paymentLinkInformation = await _payOS.getPaymentLinkInformation(orderCode);
                return new Response(0, "Ok", paymentLinkInformation);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return new Response(-1, "fail", null);
            }
        }

        public async Task<Response> CancelOrder(int orderCode, string reason)
        {
            try
            {
                PaymentLinkInformation paymentLinkInformation = await _payOS.cancelPaymentLink(orderCode, reason);
                return new Response(0, "Ok", paymentLinkInformation);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return new Response(-1, "fail", null);
            }
        }

        public async Task<Response> ConfirmWebhook(ConfirmWebhook body)
        {
            try
            {
                await _payOS.confirmWebhook(body.webhook_url);
                return new Response(0, "Ok", null);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return new Response(-1, "fail", null);
            }
        }
        public async Task<Response> CheckOrder(CheckOrderRequest request, string userEmail)
        {
            try
            {
                // Use AsNoTracking for the initial query if you're going to update later
                var user = await _unitOfWork.Repository<User>().FindAsync(u => u.Email == userEmail);
                if (user == null)
                {
                    return new Response(-1, "User not found", null);
                }

                PaymentLinkInformation paymentLinkInformation = await _payOS.getPaymentLinkInformation(request.OrderCode);

                if (paymentLinkInformation == null)
                {
                    return new Response(-1, "Payment information not found", null);
                }

                if (paymentLinkInformation.status == "PAID")
                {
                    var paymentTransaction = (await _unitOfWork.Repository<Transaction>()
                        .GetWhere(pt => pt.TransactionCode == request.OrderCode)).SingleOrDefault();

                    if (paymentTransaction == null)
                    {
                        return new Response(-1, "Transaction not found", null);
                    }

                    // Update transaction
                    paymentTransaction.Status = true;
                    paymentTransaction.UpdatedDate = DateTime.UtcNow.AddHours(7);
                    _unitOfWork.Repository<Transaction>().UpdateGuid(paymentTransaction, paymentTransaction.Id);


                    await _unitOfWork.CommitAsync();

                    var updatedUserInfo = new
                    {
                        user.Id,
                        user.FullName,
                        user.PhoneNumber,
                    };


                    return new Response(0, "Transaction Complete",
                        new { paymentInfo = paymentLinkInformation, userInfo = updatedUserInfo });
                }
                else
                {
                    return new Response(0, "Payment not completed yet",
                        new { paymentInfo = paymentLinkInformation });
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return new Response(-1, "fail", null);
            }
        }

    }
}
