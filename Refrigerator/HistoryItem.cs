namespace Refrigerator
{
    internal class HistoryItem
	{
        public HistoryItem(Product product, Activity activity)
        {
            Product = product;
            Activity = activity;
        }

        public override string ToString()
        {
            return $"{Activity} {Product}";
        }

        public readonly Product Product;
        public readonly Activity Activity;
    }
}