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
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(1);
            bst.Add(7);
            bst.Add(6);
            bst.Add(15);
            bst.Add(20);
            bst.Add(12);
            bst.Add(13);
            Console.WriteLine(bst.InOrder());
        }
    }
}
