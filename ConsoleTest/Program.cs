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
            doubleLL.Add(2);
            doubleLL.Add(3);
            doubleLL.Add(4);
            doubleLL.Insert(1, 1);
            //Console.WriteLine(doubleLL.Get(1));
            Console.WriteLine(doubleLL);
        }
    }
}
