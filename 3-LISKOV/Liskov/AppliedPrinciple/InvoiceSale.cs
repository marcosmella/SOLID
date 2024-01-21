using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.AppliedPrinciple
{
    public class InvoiceSale : SaleWithTaxes
    {
        public InvoiceSale(decimal amount, string costumer, decimal taxes)
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

        public void ExportXML()
        {
            Console.WriteLine("Export XML");
        }
    }
}
