using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoDataStructures;
using System.Text;
using System.Collections.Generic;

namespace BST_Tester
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        BinarySearchTree<int> bst = new BinarySearchTree<int>();

        public BinarySearchTreeTests()
        {
            bst.AddRange(new int[] { 10, 5, 1, 7, 6, 15, 20, 12, 13 });
        }
        
        [TestMethod]
        public void BST_InOrder()
        {
            string actual = bst.InOrder();
            string expected = "1, 5, 6, 7, 10, 20, 15, 13, 12";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void BST_PreOrder()
        {
            string actual = bst.PreOrder();
            string expected = "10, 5, 1, 7, 6, 15, 20, 12, 13";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void BST_PostOrder()
        {
            string actual = bst.PostOrder();
            string expected = "1, 6, 7, 5, 20, 13, 12, 15, 10";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void BST_Add()
        {
            int actual = bst.ToArray()[8];
            int expected = 12;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void BST_Remove()
        {
            bst.Remove(10);
            string actual = bst.InOrder();
            string expected = "1, 5, 6, 7, 20, 15, 13, 12";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void BST_ToArray()
        {
            bool areEqual = true;

            int[] actual = bst.ToArray();
            int[] expected = { 1, 5, 6, 7, 10, 20, 15, 13, 12 };

            if (actual.Length != expected.Length)
                Assert.Fail();

            for (int i = 0; i < actual.Length; ++i)
            {
                if (actual[i] != expected[i])
                {
                    areEqual = false;
                    break;
                }
            }

            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void BST_Contains()
        {
            bool expected1 = true;
            bool expected2 = false;
            bool actual1 = bst.Contains(10);
            bool actual2 = bst.Contains(21);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void BST_Clear()
        {
            bst.Clear();
            string expected = "";
            string actual = bst.InOrder();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BST_Height()
        {
            bst.Add(5);
            int expected = 5;
            int actual = bst.Height();

            Assert.AreEqual(expected, actual);
        }
    }
}
