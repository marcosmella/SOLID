namespace OpenClose.AppliedPrinciple
{
    public class Alcohol : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; }
        public decimal Promo { get; set; }
        public decimal GetTotalPrice()
        {
            return (Price * Invoice) - Promo;
        }
    }
}
