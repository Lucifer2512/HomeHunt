using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModels
{
    public class CreatePaymentLinkRequest
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CancelUrl { get; set; }
        public string ReturnUrl { get; set; }
        public string BuyerName { get; set; }
        public string BuyerPhone { get; set; }
    }

    public class ConfirmWebhook
    {
        public string WebhookUrl { get; set; }
    }

    public class CheckOrderRequest
    {
        public int OrderCode { get; set; }
    }

    public class Response
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public Response(int statusCode, string message, object data)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }
    }
}
