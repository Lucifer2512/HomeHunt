using BusinessLogicLayer.Services.Interfaces;
using BusinessLogicLayer.Types;
using Microsoft.AspNetCore.Mvc;

namespace HomeHuntAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly ILogger<TransactionController> _logger;  // Add logger

        public TransactionController(ITransactionService transactionService, ILogger<TransactionController> logger)
        {
            _transactionService = transactionService;
            _logger = logger;  // Initialize logger
        }

        [HttpGet("get-orders")]
        public async Task<IActionResult> GetOrders()
        {
            var response = await _transactionService.GetOrders();
            if (response.error == 0)
            {
                return Ok(response);
            }

            _logger.LogError("Failed to get order {OrderCode}: {Message}", response.message);
            return BadRequest(new { response.message });
        }

        [HttpGet("get-order-user/{userId}")]
        public async Task<IActionResult> GetOrderByUser(Guid userId)
        {
            var response = await _transactionService.GetOrderByUserId(userId);
            if (response.error == 0)
            {
                return Ok(response);
            }

            _logger.LogError("Failed to get order {OrderCode}: {Message}", userId, response.message);
            return BadRequest(new { response.message });
        }

        [HttpPost("create-payment-link")]
        public async Task<IActionResult> CreatePaymentLink([FromBody] CreatePaymentLinkRequest body, [FromQuery] string phone)
        {
            var response = await _transactionService.CreatePaymentLink(body, phone);
            if (response.error == 0)
            {
                return Ok(response);
            }

            _logger.LogError("Failed to create payment link for phone {Phone}: {Message}", phone, response.message);
            return BadRequest(new { response.message });
        }

        [HttpGet("get-order/{orderCode}")]
        public async Task<IActionResult> GetOrder(int orderCode)
        {
            var response = await _transactionService.GetOrder(orderCode);
            if (response.error == 0)
            {
                return Ok(response);
            }

            _logger.LogError("Failed to get order {OrderCode}: {Message}", orderCode, response.message);
            return BadRequest(new { response.message });
        }

        [HttpPost("cancel-order/{orderCode}")]
        public async Task<IActionResult> CancelOrder(int orderCode, [FromQuery] string reason)
        {
            var response = await _transactionService.CancelOrder(orderCode, reason);
            if (response.error == 0)
            {
                return Ok(response);
            }

            _logger.LogError("Failed to cancel order {OrderCode}: {Reason}, Error: {Message}", orderCode, reason, response.message);
            return BadRequest(new { response.message });
        }

        [HttpPost("confirm-webhook")]
        public async Task<IActionResult> ConfirmWebhook([FromBody] ConfirmWebhook body)
        {
            var response = await _transactionService.ConfirmWebhook(body);
            if (response.error == 0)
            {
                return Ok(response);
            }

            _logger.LogError("Failed to confirm webhook: {Message}", response.message);
            return BadRequest(new { response.message });
        }

        [HttpPost("check-order")]
        public async Task<IActionResult> CheckOrder([FromBody] CheckOrderRequest request, [FromQuery] string userPhone)
        {
            var response = await _transactionService.CheckOrder(request, userPhone);
            if (response.error == 0)
            {
                return Ok(response);
            }

            _logger.LogError("Failed to check order {OrderCode} for user {UserEmail}: {Message}", request.OrderCode, userPhone, response.message);
            return BadRequest(new { response.message });
        }
    }
}