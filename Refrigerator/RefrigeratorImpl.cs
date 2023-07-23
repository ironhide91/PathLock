using System.Collections.Concurrent;

namespace Refrigerator
{
    internal class RefrigeratorImpl : IRefrigerator, IHistory
    {
        public RefrigeratorImpl(int maximumVolume)
        {
            this.maximumVolume = maximumVolume;
            remainingVolume = maximumVolume;
            stocks = new Dictionary<string, Stock>();
            historyItems = new List<HistoryItem>();            
        }

        public bool CanInsert(Product product)
        {
            return CanAccomodate(product.Volume);
        }

        public void Insert(Product product)
        {
            if (!CanInsert(product))
            {
                Console.WriteLine("unable to insert " + product);
                Console.WriteLine(product);
                return;
            }            

            if (stocks.ContainsKey(product.Id))
            {
                stocks[product.Id].Add(product);
                Record(product, Activity.Insert);
                Console.WriteLine("insert " + product);
                return;
            }

            var stock = new Stock();
            stock.Add(product);
            stocks.TryAdd(product.Id, stock);

            Record(product, Activity.Insert);
            Console.WriteLine("insert " + product);
        }

        public bool CanConsume(Product product)
        {
            if (!stocks.ContainsKey(product.Id))
                return false;

            return stocks[product.Id].TotalQuantity >= product.QuantityValue;
        }

        public void Consume(Product product)
        {
            if (!CanConsume(product))
            {
                Console.WriteLine("unable to consume " + product);
                return;
            }

            var stock = stocks[product.Id];
            stock.Remove(product);

            Record(product, Activity.Consume);
            Console.WriteLine("consume " + product);
        }

        public IEnumerable<HistoryItem> GetHistory()
        {
            return historyItems;
        }        

        public void Record(Product product, Activity activity)
        {
            historyItems.Add(new HistoryItem(product, activity));
        }

        public void Status()
        {
            foreach (var item in stocks)
            {
                Console.WriteLine($"{item.Key} - {item.Value.TotalQuantity}");
            }

            Console.WriteLine($"max vol {maximumVolume} / empty vol {remainingVolume}");
        }

        private bool CanAccomodate(int requestedVolume)
        {
            return remainingVolume >= requestedVolume;
        }

        private readonly int maximumVolume;
        private readonly List<HistoryItem> historyItems;
        private readonly Dictionary<string, Stock> stocks;

        private int remainingVolume;
    }
}