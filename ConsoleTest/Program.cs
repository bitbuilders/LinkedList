using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoDataStructures;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxHeapPriorityQueue pq = new MaxHeapPriorityQueue();

            pq.Enqueue(1, 1);
            pq.Enqueue(2, 1);
            pq.Enqueue(3, 1);
            pq.Enqueue(4, 1);
            pq.Enqueue(5, 1);
            pq.Enqueue(6, 1);
            pq.Enqueue(7, 1);
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
        }

        static private void PrintStuff(MaxHeapPriorityQueue pq)
        {
            PQNode[] nodes = pq.ToSortedArray();
            foreach (PQNode node in nodes)
            {
                Console.WriteLine("\"" + node + "\"");
            }
        }
    }
}
