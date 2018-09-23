namespace AsyncCoinWebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class AsyncCoinController : Controller
    {
        // Get api/asynccoin/5
        [HttpGet("requestedAmount")]
        public string Get(int requestedAmount)
        {
            return $"{requestedAmount} AsyncCoin!";
        }
    }
}
