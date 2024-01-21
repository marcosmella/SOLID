using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public abstract class AbstractSale // T
    {
        protected decimal amount;
        protected decimal costumer;
        protected decimal taxes;

        public abstract void Generate();
        public abstract void CalculateTaxes();
    }

    public class Sale : AbstractSale
    {
        public Sale(decimal amount, decimal costumer, decimal taxes) 
        {
            this.amount = amount;
            this.costumer = costumer;
            this.taxes = taxes;
        }
        public override void CalculateTaxes()
        {
            Console.WriteLine("Calculate Taxes..");
        }

        public override void Generate()
        {
            Console.WriteLine("Generat Sale..");
        }
    }

    public class ForeignSale : AbstractSale
    {
        public ForeignSale(decimal amount, decimal costumer, decimal taxes)
        {
            this.amount = amount;
            this.costumer = costumer;
            this.taxes = 0; //I would be put 0, but what happend if exist more fields?
        }
        public override void CalculateTaxes()
        {
            //i.e: can't calculate Taxes in other country in this case.
            throw new NotImplementedException();
        }

        public override void Generate()
        {
            Console.WriteLine("Generat Sale..");
        }
    }
}
