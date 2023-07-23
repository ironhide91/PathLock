namespace Refrigerator
{
    internal interface IHistory
    {
        IEnumerable<HistoryItem> GetHistory();

        void Record(Product product, Activity activity);
    }
}