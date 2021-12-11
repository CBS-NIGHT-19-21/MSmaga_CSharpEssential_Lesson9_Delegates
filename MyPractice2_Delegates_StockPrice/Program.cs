namespace Delegates_StockPrice
{
    class Program
    {
        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is: {price}");
        }
        static void Main(string[] args)
        {
            // Instace class StockExchageMonitor.
            StockExchageMonitor stockExchageMonitor = new StockExchageMonitor();

            // Assign static method ShowPrice to delegate AutoProperty.

            stockExchageMonitor.PriceChangeHandler = ShowPrice;
            // Call delegate AutoProperty from
            // class StockExchageMonitor method Start().
            stockExchageMonitor.Start();

            // Delay.
            Console.ReadLine();
        }
    }
}