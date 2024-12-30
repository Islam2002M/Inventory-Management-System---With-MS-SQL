namespace PublisherDomain
{
    public class Price
    {
        public double ItemPrice { get; set; }
        public Currency Curr { get; set; }

        public Price(double itemPrice, Currency curr)
        {
            ItemPrice = itemPrice;
            Curr = curr;
        }

        public override string ToString()
        {
            return $"{ItemPrice} {Curr}";
        }
    }
}