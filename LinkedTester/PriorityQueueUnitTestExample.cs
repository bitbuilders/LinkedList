using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoDataStructures;
using System.Text;

namespace MaxHeapTester
{
    [TestClass]
    public class PriorityQueueUnitTest
    {
        #region Tests
        [TestMethod]
        public void CountIsCorrectAfterSingleAdd()
        {
            MaxHeapPriorityQueue pq = new MaxHeapPriorityQueue();

            pq.Enqueue(1, 100); // priority 1, value 100
            pq.Enqueue(50, 100); // priority 50, value 100
            PQNode node = pq.Peek(); // Returns highest priority node
            PQNode node2 = pq.Dequeue(); // Returns/Removes highest priority node
            int count = pq.Count; // Returns the node count
            string value = pq.ToString(); // Returns the string representation of the queue - p1:v1, p2:v2, p3:v3,...,pn:vn

            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void CountIsCorrectAfterSingleRemove()
        {

        }

        [TestMethod]
        public void CountIsCorrectAfterAddRemoveAdd()
        {

        }

        [TestMethod]
        public void CountIsUnchagedAfterPeek()
        {

        }

        [TestMethod]
        public void CountIsZeroForNewPQ()
        {

        }

        //Dequeue
        [TestMethod]
        public void DequeueSingleNodePQ()
        {

        }

        [TestMethod]
        public void DequeueFullTreeToEmpty()
        {

        }

        //Peek
        [TestMethod]
        public void PeekSingleNodePQ()
        {

        }

        [TestMethod]
        public void PeekThreeNodePQ()
        {

        }

        [TestMethod]
        public void PeekThirteenNodePQ()
        {

        }

        //ToString
        [TestMethod]
        public void ToStringSingleNodePQ()
        {

        }

        #endregion
    }
}
