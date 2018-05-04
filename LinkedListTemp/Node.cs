using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public class Node<T>
    {
        public T value = default(T);
        public Node<T> next = null;
        public Node<T> previous = null;
    }
}
