namespace Refrigerator
{
    internal interface IMonitorExpiration
    {
        void Monitor(IReadOnlyDictionary<string, Stock> stocks, int interval, TimeSpan offset);
    }
}