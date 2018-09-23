namespace AsyncCoinWebApi.Controllers
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class AsyncCoinController : Controller
    {
        // Get api/asynccoin/5
        [HttpGet("{howMany}")]
        public async Task<string> GetAsync(int howMany)
        {
            return await this.AcquireAsyncCoinAsync(howMany);
        }

        private async Task<string> AcquireAsyncCoinAsync(int howMany)
        {
            string message = string.Empty;
            message += $"Your mining operation started at {DateTime.Now}";

            string result;

            var uri = new Uri($"https://asynccoinfunction.azurewebsites.net/api/asynccoin/{howMany}");
            using (var client = new HttpClient())
            {
                result = await client.GetStringAsync(uri).ConfigureAwait(false);
            }

            message += $"Your mining operation finished at {DateTime.Now}";
            message += $"result: {result}";
            return message;
        }
    }
}
