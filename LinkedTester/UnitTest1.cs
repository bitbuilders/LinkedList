using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoDataStructures;
using System.Text;
using System.Collections.Generic;

namespace LinkedListTester
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void SLL_EmptyList()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            int expectedCount = 0;
            int actualCount = list.Count;

            string expectedString = "";
            string actualString = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void SLL_Add()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int expectedCount = 3;
            int actualCount = list.Count;
            string expectedOutput = "1, 2, 3";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_RemoveFirstEmpty()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Remove();
            int expectedCount = 0;
            int actualCount = list.Count;
            string expectedOutput = "";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_RemoveFirstFull()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Remove();
            int expectedCount = 1;
            int actualCount = list.Count;
            string expectedOutput = "2";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_RemoveLastEmpty()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.RemoveLast();
            int expectedCount = 0;
            int actualCount = list.Count;
            string expectedOutput = "";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_RemoveLastFull()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.RemoveLast();
            int expectedCount = 1;
            int actualCount = list.Count;
            string expectedOutput = "1";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_RemoveAtFull()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);
            int expectedCount = 2;
            int actualCount = list.Count;
            string expectedOutput = "1, 3";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_ClearEmpty()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Clear();
            int expectedCount = 0;
            int actualCount = list.Count;
            string expectedOutput = "";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_ClearFull()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            list.Clear();
            int expectedCount = 0;
            int actualCount = list.Count;
            string expectedOutput = "";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_Insert()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            list.Insert(2, 1);
            int expectedCount = 3;
            int actualCount = list.Count;
            string expectedOutput = "1, 2, 3";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SLL_Get()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            int expectedNumber = 3;
            int actualNumber = list.Get(1);

            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void SLL_SearchNothing()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            int expectedNumber = -1;
            int actualNumber = list.Search(0);

            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void SLL_SearchActual()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            int expectedNumber = 1;
            int actualNumber = list.Search(3);

            Assert.AreEqual(expectedNumber, actualNumber);
        }




        [TestMethod]
        public void DLL_EmptyList()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            int expectedCount = 0;
            int actualCount = list.Count;

            string expectedString = "";
            string actualString = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void DLL_Add()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int expectedCount = 3;
            int actualCount = list.Count;
            string expectedOutput = "1, 2, 3";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_RemoveFirstEmpty()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Remove();
            int expectedCount = 0;
            int actualCount = list.Count;
            string expectedOutput = "";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_RemoveFirstFull()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Remove();
            int expectedCount = 1;
            int actualCount = list.Count;
            string expectedOutput = "2";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_RemoveLastEmpty()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.RemoveLast();
            int expectedCount = 0;
            int actualCount = list.Count;
            string expectedOutput = "";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_RemoveLastFull()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.RemoveLast();
            int expectedCount = 1;
            int actualCount = list.Count;
            string expectedOutput = "1";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_RemoveAtFull()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);
            int expectedCount = 2;
            int actualCount = list.Count;
            string expectedOutput = "1, 3";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_ClearEmpty()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Clear();
            int expectedCount = 0;
            int actualCount = list.Count;
            string expectedOutput = "";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_ClearFull()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            list.Clear();
            int expectedCount = 0;
            int actualCount = list.Count;
            string expectedOutput = "";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_Insert()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            list.Insert(2, 1);
            int expectedCount = 3;
            int actualCount = list.Count;
            string expectedOutput = "1, 2, 3";
            string actualOutput = list.ToString();

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DLL_Get()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            int expectedNumber = 3;
            int actualNumber = list.Get(1);

            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void DLL_SearchNothing()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            int expectedNumber = -1;
            int actualNumber = list.Search(0);

            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void DLL_SearchActual()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(3);
            int expectedNumber = 1;
            int actualNumber = list.Search(3);

            Assert.AreEqual(expectedNumber, actualNumber);
        }
    }
}
