using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class Drink
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }

    public class Invoice
    {
         public decimal GetTotal(IEnumerable<Drink> drinks)
         {
            decimal total = 0;
            foreach (var drink in drinks)
            {
                if (drink.Type == "Water")
                {
                    total += drink.Price;

                }
                else if (drink.Type == "Juice")
                {
                    total += drink.Price * 1.35m;

                }
                else if(drink.Type == "Alcohol")
                {
                    total += drink.Price * 2.50m;
                }
                else if (drink.Type == "Energizing")
                {
                    total += drink.Price * 2.99m;
                }                
            }

            return total;
         }
    }
}
