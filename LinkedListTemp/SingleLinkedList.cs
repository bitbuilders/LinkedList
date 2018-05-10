using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public class SingleLinkedList<T>
    {
        private SingleNode<T> head = null;
        private SingleNode<T> tail = null;
        public int Count { get; private set; }

        public void Add(T val)
        {
            SingleNode<T> SingleNode = new SingleNode<T>();
            SingleNode.value = val;
            Count++;

            if (Count == 1)
            {
                head = SingleNode;
                tail = SingleNode;
            }
            else
            {
                SingleNode<T> prevSingleNode = head;
                for (int i = 1; i < Count - 1; ++i)
                {
                    prevSingleNode = prevSingleNode.next;
                }
                prevSingleNode.next = SingleNode;

                tail = SingleNode;
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

            if (index == 0 && Count > 1)
            {
                val = Remove();
            }
            else if (index >= 0 && index <= Count - 1)
            {
                SingleNode<T> currentSingleNode = head;
                SingleNode<T> prev = null;
                SingleNode<T> next = null;
                prev = head;
                for (int i = 1; i <= index + 1; ++i)
                {
                    currentSingleNode = currentSingleNode.next;
                    if (i == index - 1)
                    {
                        prev = currentSingleNode;
                    }
                    else if (i == index)
                    {
                        val = currentSingleNode.value;
                    }
                    else if (i == index + 1)
                    {
                        next = currentSingleNode;
                    }
                    if (i == index - 1 && index == Count -1)
                    {
                        tail = currentSingleNode;
                    }
                }

                prev.next = next;

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
            else if (Count > 1)
            {
                SingleNode<T> currentSingleNode = head;
                for (int i = 1; i < Count - 1; ++i)
                {
                    currentSingleNode = currentSingleNode.next;
                }
                tail = currentSingleNode;
                val = currentSingleNode.next.value;
                currentSingleNode.next = null;

                Count--;
            }

            return val;
        }

        public void Insert(T val, int index)
        {
            if (index == 0)
            {
                SingleNode<T> newSingleNode = new SingleNode<T>();
                newSingleNode.value = val;
                newSingleNode.next = head;
                head = newSingleNode;

                Count++;
            }
            else if (index >= 0 && index <= Count - 1)
            {
                SingleNode<T> newSingleNode = new SingleNode<T>();
                newSingleNode.value = val;
                SingleNode<T> currentSingleNode = head;
                SingleNode<T> prev = head;
                for (int i = 1; i <= index; ++i)
                {
                    currentSingleNode = currentSingleNode.next;
                    if (i == index - 1)
                    {
                        prev = currentSingleNode;
                    }
                    else if (i == index)
                    {
                        newSingleNode.next = currentSingleNode;
                    }
                }
                prev.next = newSingleNode;
                if (index == 1)
                {
                    head.next = newSingleNode;
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

            if (index == 0 && Count > 0)
            {
                val = head.value;
            }
            else if (index >= 0 && index <= Count - 1)
            {
                SingleNode<T> currentSingleNode = head;
                for (int i = 1; i < index + 1; ++i)
                {
                    currentSingleNode = currentSingleNode.next;
                }

                val = currentSingleNode.value;
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

            SingleNode<T> currentSingleNode = head;
            for (int i = 0; i < Count; ++i)
            {
                if (currentSingleNode.value.Equals(val))
                {
                    index = i;
                    break;
                }
                currentSingleNode = currentSingleNode.next;
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

                SingleNode<T> currentSingleNode = head.next;
                for (int i = 1; i < Count - 1; ++i)
                {
                    sb.Append(currentSingleNode.value);
                    sb.Append(", ");
                    currentSingleNode = currentSingleNode.next;
                }
                if (currentSingleNode != null)
                {
                    sb.Append(currentSingleNode.value);
                }
            }

            return sb.ToString();
        }
    }
}
