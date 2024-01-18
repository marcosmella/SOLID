﻿namespace OpenClose.AppliedPrinciple
{
    public class Energizing : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; }
        public decimal Expiration { get; set; }
        public DateTime Created { get; set; }
        public decimal GetTotalPrice()
        {
            return (Price * Invoice) - Expiration;
        }
    }
}
