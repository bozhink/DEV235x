namespace AsyncCoinWebApi.Controllers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class AsyncCoinController : Controller
    {
        // Get api/asynccoin/5
        [HttpGet("{requestedAmount}")]
        public async Task<string> GetAsync(int requestedAmount)
        {
            return await this.AcquireAsyncCoinAsync(requestedAmount);
        }

        private string AcquireAsyncCoin(int requestedAmount)
        {
            string message = string.Empty;
            message += $"Your mining operation started at {DateTime.Now}";
            var result = this.PretendToConnectToCoinService(requestedAmount);
            message += $"Your mining operation finished at {DateTime.Now}";
            message += $"result: {result}";
            return message;
        }

        private async Task<string> AcquireAsyncCoinAsync(int requestedAmount)
        {
            string message = string.Empty;
            message += $"Your mining operation started at {DateTime.Now}";
            var result = await this.PretendToConnectToCoinServiceAsync(requestedAmount);
            message += $"Your mining operation finished at {DateTime.Now}";
            message += $"result: {result}";
            return message;
        }

        private string PretendToConnectToCoinService(int requestedAmount)
        {
            // Simulate a long-running network connection
            Thread.Sleep(requestedAmount * 1000);
            return $"You've got {requestedAmount} AsyncCoin!";
        }

        private async Task<string> PretendToConnectToCoinServiceAsync(int requestedAmount)
        {
            // Simulate a long-running network connection
            await Task.Delay(requestedAmount * 1000);
            return $"You've got {requestedAmount} AsyncCoin!";
        }
    }
}
