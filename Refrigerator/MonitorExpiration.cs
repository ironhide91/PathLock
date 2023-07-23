namespace Refrigerator
{
    internal class MonitorExpiration : IMonitorExpiration
    {
        public MonitorExpiration()
        {

        }

        public void Monitor(IReadOnlyDictionary<string, Stock> stocks, int interval, TimeSpan offset)
        {
            // start timer on bg thread
        }

        private void CheckForExpiry()
        {
            // loop on stock
            // remove products that have expiry within offset range
        }

        private readonly TimeSpan offset;

        private IReadOnlyDictionary<string, Stock> stocks;
    }
}