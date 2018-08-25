namespace AsyncCoinConsole
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class AsyncCoinManager
    {
        public void AcquireAsyncCoin()
        {
            System.Console.WriteLine($"Start call to long-running service at {DateTime.Now}");
            var result = this.PretendToConnectToCoinService();
            System.Console.WriteLine($"Finish call to long-running service at {DateTime.Now}");
            var savedColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"result: {result}");
            System.Console.ForegroundColor = savedColor;
        }

        public async Task AcquireAsyncCoinAsync()
        {
            Console.WriteLine($"Start call to long-running service at {DateTime.Now}");
            var result = await PretendToConnectToCoinServiceAsync();
            Console.WriteLine($"Finish call to long-running service at {DateTime.Now}");
            var savedColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"result: {result}");
            Console.ForegroundColor = savedColor;
        }


        private string PretendToConnectToCoinService()
        {
            // Simulate a long-running network connection.
            Thread.Sleep(5000);
            return "You've got 25 AsyncCoin!";
        }

        private async Task<string> PretendToConnectToCoinServiceAsync()
        {
            // Simulate a long-running network connection.
            await Task.Delay(5000);
            return "You've got 25 AsyncCoin!";
        }
    }
}