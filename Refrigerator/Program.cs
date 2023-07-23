namespace Refrigerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new RefrigeratorImpl(5000);

            var milk = new Product(
                "milk",
                QuantityType.Millilitre,
                quantityValue: 1,
                volume: 500,
                DateTime.Now.AddSeconds(10));

            app.Consume(milk);
            app.Status();
            app.Insert(milk);
            app.Status();
            app.Consume(milk);
            app.Status();
            app.Consume(milk);
            app.Status();
            
            var history = app.GetHistory();

            foreach (var item in history)
                Console.WriteLine(item);
        }
    }
}