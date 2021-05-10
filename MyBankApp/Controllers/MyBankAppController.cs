using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBankApp.Api.Model;
using MyBankApp.Api.Service;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyBankApp.Api.Controllers
{
    [EnableCors("MyBankAppPolicy")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MyBankAppController : ControllerBase
    {
        private readonly IMyBankAppRepository myBankAppRepository;
        private readonly ILogger<MyBankAppController> logger;

        public MyBankAppController(IMyBankAppRepository _myBankAppRepository, IHttpClientFactory _httpClientFactory, ILogger<MyBankAppController> _logger)
        {
            myBankAppRepository = _myBankAppRepository;
            logger = _logger;
        }

        [HttpGet("CurrentBalance/{bankAccountId}")]
        public async Task<IActionResult> GetCurrentBalance(int bankAccountId)
        {
            logger.LogInformation("GetCurrentBalance - MyBankApp.Api");
            var res = await myBankAppRepository.GetCurrentBalance(bankAccountId);
            return Ok(res);
        }

        [HttpPost("Withdraw")]
        public async Task<IActionResult> Withdraw([FromBody] Transaction transaction)
        {
            logger.LogInformation("Withdraw - MyBankApp.Api");
            var res = await myBankAppRepository.WithDrawn(transaction);
            return Ok(res);
        }

        [HttpPost("Deposit")]
        public async Task<IActionResult> Deposit([FromBody] Transaction transaction)
        {
            logger.LogInformation("Deposit - MyBankApp.Api");
            var res = await myBankAppRepository.Deposit(transaction);
            return Ok(res);
        }
    }
}
