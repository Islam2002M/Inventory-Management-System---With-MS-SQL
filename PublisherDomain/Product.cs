namespace PublisherDomain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public Price Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - Quantity: {Quantity} - Price: {Price}";
        }
    }
}