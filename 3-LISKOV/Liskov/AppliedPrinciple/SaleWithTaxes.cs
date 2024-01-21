using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.AppliedPrinciple
{
    public abstract class SaleWithTaxes : BaseSale
    {
        protected decimal taxes;
        public abstract void CalculateTaxes();
    }
}
