public class StockExchageMonitor
{   // Declare an delegate type what gets int parameter
    // returns no value.
    public delegate void PriceChange(int price);

    // Declare an delegate AutoProperty type PriceChange
    public PriceChange? PriceChangeHandler { get; set; }

    // Declare class method to generate the price.
    public void Start()
    {
        while (true)
        {
            int bankOfAmericaPrice = (new Random()).Next(100);

            // Call method from delegate AutoProperty.
            PriceChangeHandler!(bankOfAmericaPrice);
            Thread.Sleep(500);
        }
    }

}

