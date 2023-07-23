namespace Refrigerator
{
    internal interface IRefrigerator
    {
        bool CanInsert(Product product);

        void Insert(Product product);

        bool CanConsume(Product product);

        void Consume(Product product);

        void Status();
    }
}