using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.AppliedPrinciple
{
    public class ForeignSale : BaseSale
    {
        public ForeignSale(decimal amount, string costumer, decimal taxes)
        {
            this.amount = amount;
            this.costumer = costumer;
        }

        public override void Generate()
        {
            Console.WriteLine("Generat Sale..");
        }
    }
}
