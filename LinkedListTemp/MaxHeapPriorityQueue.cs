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
            if (Count > m_nodes.Length)
            {
                PQNode[] newNodes = new PQNode[m_nodes.Length * 2];
                Array.Copy(m_nodes, newNodes, m_nodes.Length);
                m_nodes = newNodes;
            }

            m_nodes[Count - 1] = node;
            HeapifyEnqueue(Count - 1);
        }

        private void HeapifyEnqueue(int curIndex)
        {
            PQNode parent = GetParentOf(curIndex);

            if (m_nodes[curIndex].priority > parent.priority)
            {
                SwapParentOfChild(curIndex);
                HeapifyEnqueue((curIndex - 1) / 2);
            }
        }

        public PQNode Dequeue()
        {
            return null;
        }

        public PQNode Peek()
        {
            return m_nodes[0];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Count > 0)
                sb.Append(m_nodes[0]);

            for (int i = 1; i < m_nodes.Length; i++)
            {
                if (m_nodes[i] != null)
                    sb.Append($",{m_nodes[i]}");
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
            return m_nodes[node * 2];
        }

        private PQNode GetRightChildOf(int node)
        {
            return m_nodes[node * 2 + 1];
        }

        private PQNode GetParentOf(int node)
        {
            return m_nodes[(node - 1) / 2];
        }

        private void SwapParentOfChild(int child)
        {
            PQNode temp = m_nodes[child];
            m_nodes[child] = m_nodes[(child - 1) / 2];
            m_nodes[(child - 1) / 2] = temp;
        }
    }
}
