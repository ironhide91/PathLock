namespace Refrigerator
{
    internal class Product
    {
        public Product(string id, QuantityType quantityType, int quantityValue, int volume, DateTime expiry)
        {
            Id = id;
            QuantityType = quantityType;
            QuantityValue = quantityValue;
            Volume = volume;
            Expiry = expiry;
        }
        public override string ToString()
        {
            return $"[ {Id} qty {QuantityValue} {QuantityType} vol {Volume} ]";
        }

        public readonly string Id;
        public readonly QuantityType QuantityType;
        public readonly int QuantityValue;
        public readonly int Volume;
        public readonly DateTime Expiry;
    }
}