using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public class MaxHeapPriorityQueue
    {
        private PQNode[] m_nodes;

        public MaxHeapPriorityQueue()
        {
            m_nodes = new PQNode[2];
            Count = 0;
        }

        public int Count { get; private set; }

        public void Enqueue(int priority, int value)
        {
            PQNode node = new PQNode(priority, value);
            Count++;
            if (Count >= m_nodes.Length)
            {
                PQNode[] newNodes = new PQNode[m_nodes.Length * 2];
                Array.Copy(m_nodes, newNodes, m_nodes.Length);
                m_nodes = newNodes;
            }

            m_nodes[Count] = node;
            HeapifyEnqueue(Count);
        }

        private void HeapifyEnqueue(int curIndex)
        {
            PQNode parent = GetParentOf(curIndex);

            if (parent != null && m_nodes[curIndex].Priority > parent.Priority)
            {
                SwapParentOfChild(curIndex);
                HeapifyEnqueue(ParentIndex(curIndex));
            }
        }

        public PQNode Dequeue()
        {
            PQNode node = null;
            if (Count > 0)
            {
                node = Peek();
                m_nodes[1] = m_nodes[Count];
                m_nodes[Count] = null;
                Count--;

                if (Count > 0)
                {
                    HeapifyDequeue(1);
                }
            }

            return node;
        }

        private void HeapifyDequeue(int curIndex)
        {
            PQNode left = GetLeftChildOf(curIndex);
            PQNode right = GetRightChildOf(curIndex);

            int larger = -1;
            if (left == null && right != null) larger = RightChildIndex(curIndex);
            else if (left != null && right == null) larger = LeftChildIndex(curIndex);
            else if (left != null && right != null) larger = left.Priority > right.Priority ? LeftChildIndex(curIndex) : RightChildIndex(curIndex);

            if (larger != -1)
            {
                if (m_nodes[larger].Priority > m_nodes[curIndex].Priority)
                {
                    SwapParentOfChild(larger);
                    HeapifyDequeue(larger);
                }
            }
        }

        public PQNode Peek()
        {
            return m_nodes[1];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Count > 0)
                sb.Append(m_nodes[1]);

            for (int i = 2; i < m_nodes.Length; i++)
            {
                if (m_nodes[i] != null)
                    sb.Append($", {m_nodes[i]}");
                else
                    break;
            }

            return sb.ToString();
        }

        public PQNode[] ToSortedArray()
        {
            PQNode[] array = new PQNode[Count];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Dequeue();
            }

            return array;
        }

        private PQNode GetLeftChildOf(int node)
        {
            if (LeftChildIndex(node) >= m_nodes.Length) return null;
            return m_nodes[LeftChildIndex(node)];
        }

        private PQNode GetRightChildOf(int node)
        {
            if (RightChildIndex(node) >= m_nodes.Length) return null;
            return m_nodes[RightChildIndex(node)];
        }

        private PQNode GetParentOf(int node)
        {
            return m_nodes[ParentIndex(node)];
        }

        private void SwapParentOfChild(int child)
        {
            PQNode temp = m_nodes[child];
            m_nodes[child] = m_nodes[ParentIndex(child)];
            m_nodes[ParentIndex(child)] = temp;
        }

        private int LeftChildIndex(int node)
        {
            return node * 2;
        }

        private int RightChildIndex(int node)
        {
            return node * 2 + 1;
        }

        private int ParentIndex(int node)
        {
            return node / 2;
        }
    }
}
