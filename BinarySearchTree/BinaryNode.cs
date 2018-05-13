using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public class BinaryNode<T> where T : IComparable
    {
        public T value = default(T);
        public BinaryNode<T> left = null;
        public BinaryNode<T> right = null;
    }
}
