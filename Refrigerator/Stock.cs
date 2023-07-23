namespace Refrigerator
{
    internal class Stock
    {
        public Stock()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            lock (lockObj)
            {
                products.Add(product);
                TotalQuantity += product.QuantityValue;
            }
        }

        public void Remove(Product product)
        {
            lock (lockObj)
            {
                products.Remove(product);
                TotalQuantity -= product.QuantityValue;
            }
        }

        public int TotalQuantity { get; private set; }

        private readonly List<Product> products;
        private readonly object lockObj;
    }
}