namespace OpenClose.AppliedPrinciple
{
    public class Invoice
    {
        public decimal GetTotal(IEnumerable<IDrink> drinks)
        {
            decimal total = 0;
            foreach (var drink in drinks)
            {
                total += drink.GetTotalPrice();
            }

            return total;
        }
    }
}
