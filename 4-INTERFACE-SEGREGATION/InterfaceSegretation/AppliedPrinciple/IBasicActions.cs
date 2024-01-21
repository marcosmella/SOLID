using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegretation.AppliedPrinciple
{
    public interface IBasicActions<T>
    {
        public T Get(int id);
        public List<T> GetAll();
        public void Add(T entity);
    }
}
