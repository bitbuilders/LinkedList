using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    class DoubleNode<T>
    {
        public T value = default(T);
        public DoubleNode<T> next = null;
        public DoubleNode<T> previous = null;
    }
}
