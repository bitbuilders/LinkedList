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
            SingleLinkedList<int> singleLL = new SingleLinkedList<int>();
            DoubleLinkedList<int> doubleLL = new DoubleLinkedList<int>();
            singleLL.Add(2);
            singleLL.Add(3);
            singleLL.Add(4);
            Console.WriteLine(singleLL.Search(2));
            Console.WriteLine(singleLL);
        }
    }
}
