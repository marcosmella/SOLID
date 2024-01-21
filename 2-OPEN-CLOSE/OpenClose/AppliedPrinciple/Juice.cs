namespace OpenClose.AppliedPrinciple
{
    public class Juice : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; }
        public decimal SuggarCost { get; set; }
        public int Country { get; set; }

        public decimal GetTotalPrice()
        {
            return (Price * Invoice) + SuggarCost;
        }
    }
}
