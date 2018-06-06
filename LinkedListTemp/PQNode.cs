using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public class PQNode
    {
        public PQNode(int prio, int val)
        {
            Priority = prio;
            Value = val;
        }

        public int Priority { get; private set; }
        public int Value { get; private set; }

        public override string ToString()
        {
            return $"{Priority}:{Value}";
        }
    }
}
