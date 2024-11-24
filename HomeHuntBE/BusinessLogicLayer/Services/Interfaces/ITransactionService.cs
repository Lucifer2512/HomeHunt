using BusinessLogicLayer.Types;
using DataAccessLayer.Models;
using Net.payOS.Types;
using Net.payOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface ITransactionService
    {
        Task<Response> GetOrders();

        Task<Response> GetOrderByUserId(Guid userId);

        Task<Response> CreatePaymentLink(CreatePaymentLinkRequest body, string Phone);

        Task<Response> GetOrder(int orderCode);

        Task<Response> CancelOrder(int orderCode, string reason);

        Task<Response> ConfirmWebhook(ConfirmWebhook body);

        Task<Response> CheckOrder(CheckOrderRequest request, string userEmail);


    }
}
