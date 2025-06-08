using Microsoft.AspNetCore.Mvc;
using ATMMachine.Core;

namespace ATMMachine.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ATMController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public ATMController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("validate")]
        public IActionResult ValidatePin([FromBody] PinValidationRequest request)
        {
            var isValid = _accountService.ValidatePin(request.CardNumber, request.Pin);
            return Ok(new { isValid });
        }

        [HttpGet("balance/{cardNumber}")]
        public IActionResult GetBalance(string cardNumber)
        {
            var balance = _accountService.GetBalance(cardNumber);
            return Ok(new { balance });
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw([FromBody] TransactionRequest request)
        {
            var success = _accountService.Withdraw(request.CardNumber, request.Amount);
            return Ok(new { success });
        }

        [HttpPost("deposit")]
        public IActionResult Deposit([FromBody] TransactionRequest request)
        {
            _accountService.Deposit(request.CardNumber, request.Amount);
            return Ok(new { success = true });
        }
    }

    public class PinValidationRequest
    {
        public string CardNumber { get; set; }
        public string Pin { get; set; }
    }

    public class TransactionRequest
    {
        public string CardNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
