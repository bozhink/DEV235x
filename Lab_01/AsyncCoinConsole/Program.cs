namespace AsyncCoinConsole
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var coinManager = new AsyncCoinManager();
            var coinTask = coinManager.AcquireAsyncCoinAsync();
            Console.WriteLine("from main: I am not blocked");
            await coinTask;
            Console.ReadLine();
        }
    }
}
