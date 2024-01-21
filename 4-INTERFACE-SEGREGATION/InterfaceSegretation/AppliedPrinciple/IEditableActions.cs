using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegretation.AppliedPrinciple
{
    public interface IEditableActions<T>
    {
        public void Update(T entity);
        public void Delete(int id);
    }
}
