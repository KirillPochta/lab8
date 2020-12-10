using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4100
{
    interface IGeneralization<T>
    {
        public void Check();
        public void Add(T[] item);
        public void Remove(T item);
    }
}
