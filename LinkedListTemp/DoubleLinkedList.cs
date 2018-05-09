using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public class DoubleLinkedList<T>
    {
        private DoubleNode<T> head = null;
        private DoubleNode<T> tail = null;
        public int Count { get; private set; }

        public void Add(T val)
        {
            DoubleNode<T> node = new DoubleNode<T>();
            node.value = val;
            Count++;

            if (Count == 1)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.previous = tail;
                tail.next = node;
                tail = node;
            }
        }

        public T Remove()
        {
            // Removes first value in list
            T val = default(T);

            if (Count > 0)
            {
                val = head.value;
                head = head.next;
                if (Count == 1)
                {
                    tail = null;
                }
                Count--;
            }

            return val;
        }

        public T RemoveAt(int index)
        {
            // Removes value at index and returns
            T val = default(T);

            if (index == 0)
            {
                val = Remove();
            }
            else if (index >= 0 && index <= Count - 1)
            {
                DoubleNode<T> currentDoubleNode = head;
                for (int i = 1; i < index + 1; ++i)
                {
                    currentDoubleNode = currentDoubleNode.next;
                    if (i == index)
                    {
                        currentDoubleNode.previous.next = currentDoubleNode.next;
                        val = currentDoubleNode.value;
                    }
                    if (i == index - 1 && index == Count - 1)
                    {
                        tail = currentDoubleNode;
                    }
                }

                Count--;
            }
            else
            {
                throw new IndexOutOfRangeException($"{index} is too large or small for a list the size of {Count}");
            }

            return val;
        }

        public T RemoveLast()
        {
            // Removes and returns last
            T val = default(T);

            if (Count == 1)
            {
                val = Remove();
            }
            else
            {
                val = tail.value;
                tail = tail.previous;

                Count--;
            }

            return val;
        }

        public void Insert(T val, int index)
        {
            if (index == 0)
            {
                DoubleNode<T> newDoubleNode = new DoubleNode<T>();
                newDoubleNode.value = val;
                newDoubleNode.next = head;
                head = newDoubleNode;

                Count++;
            }
            else if (index >= 0 && index <= Count - 1)
            {
                DoubleNode<T> newNode = new DoubleNode<T>();
                newNode.value = val;
                DoubleNode<T> currentNode = head;
                for (int i = 1; i < index; ++i)
                {
                    currentNode = currentNode.next;
                    if (i == index)
                    {
                        currentNode.previous = newNode;
                        newNode.next = currentNode.next;
                        currentNode.previous = newNode;
                    }
                }
                if (index == 1)
                {
                    head.next = newNode;
                }

                Count++;
            }
            else
            {
                throw new IndexOutOfRangeException($"{index} is too large or small for a list the size of {Count}");
            }
        }

        public T Get(int index)
        {
            T val = default(T);

            if (index == 0)
            {
                val = head.value;
            }
            else if (index >= 0 && index <= Count - 1)
            {
                DoubleNode<T> currentDoubleNode = head;
                for (int i = 1; i < index + 1; ++i)
                {
                    currentDoubleNode = currentDoubleNode.next;
                }

                val = currentDoubleNode.value;
            }
            else
            {
                throw new IndexOutOfRangeException($"{index} is too large or small for a list the size of {Count}");
            }

            return val;
        }

        public void Clear()
        {
            Count = 0;
            head = null;
            tail = null;
        }

        public int Search(T val)
        {
            int index = -1;

            DoubleNode<T> currentDoubleNode = head;
            for (int i = 0; i < Count; ++i)
            {
                if (currentDoubleNode.value.Equals(val))
                {
                    index = i;
                    break;
                }
                currentDoubleNode = currentDoubleNode.next;
            }

            return index;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Count > 0)
            {
                sb.Append(head.value);
                if (Count > 1)
                {
                    sb.Append(", ");
                }

                DoubleNode<T> currentDoubleNode = head.next;
                for (int i = 1; i < Count - 1; ++i)
                {
                    sb.Append(currentDoubleNode.value);
                    sb.Append(", ");
                    currentDoubleNode = currentDoubleNode.next;
                }
                if (currentDoubleNode != null)
                {
                    sb.Append(currentDoubleNode.value);
                }
            }

            return sb.ToString();
        }
    }
}
