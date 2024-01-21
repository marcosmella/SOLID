using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.AppliedPrinciple
{
    public abstract class BaseSale
    {
        protected decimal amount;
        protected string costumer;
        public abstract void Generate();
    }
}
