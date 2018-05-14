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
            bst.AddRange(new int[] { 10, 5, 1, 7, 6, 15, 20, 12, 13 });

            bst.Clear();
            Console.WriteLine(bst.Height());
            Console.WriteLine(bst.InOrder());
        }
    }
}
