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
            priority = prio;
            value = val;
        }

        public int priority;
        public int value;

        public override string ToString()
        {
            return $"{priority}:{value}";
        }
    }
}
