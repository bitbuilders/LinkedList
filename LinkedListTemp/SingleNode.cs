using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public class SingleNode<T>
    {
        public T value = default(T);
        public SingleNode<T> next = null;
    }
}
