using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public class SingleLinkedList<T>
    {
        private Node<T> head = null;
        private Node<T> tail = null;
        public int Count { get; private set; }

        public void Add(T val)
        {
            Node<T> node = new Node<T>();
            node.value = val;
            Count++;

            if (Count == 1)
            {
                head = node;
                tail = node;
            }
            else
            {
                Node<T> prevNode = head;
                for (int i = 1; i < Count - 1; ++i)
                {
                    prevNode = prevNode.next;
                }
                prevNode.next = node;

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
                Node<T> currentNode = head;
                Node<T> prev = null;
                Node<T> next = null;
                prev = head;
                for (int i = 1; i < index + 1; ++i)
                {
                    currentNode = currentNode.next;
                    if (i == index - 1)
                    {
                        prev = currentNode;
                    }
                    else if (i == index)
                    {
                        val = currentNode.value;
                    }
                    else if (i == index + 1)
                    {
                        next = currentNode;
                    }
                    if (i == index - 1 && index == Count -1)
                    {
                        tail = currentNode;
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
            else
            {
                Node<T> currentNode = head;
                for (int i = 1; i < Count - 1; ++i)
                {
                    currentNode = currentNode.next;
                }
                tail = currentNode;
                val = currentNode.next.value;
                currentNode.next = null;

                Count--;
            }

            return val;
        }

        public void Insert(T val, int index)
        {
            if (index == 0)
            {
                Node<T> newNode = new Node<T>();
                newNode.value = val;
                newNode.next = head;
                head = newNode;

                Count++;
            }
            else if (index >= 0 && index <= Count - 1)
            {
                Node<T> newNode = new Node<T>();
                newNode.value = val;
                Node<T> currentNode = head;
                Node<T> prev = head;
                for (int i = 1; i < index; ++i)
                {
                    currentNode = currentNode.next;
                    if (i == index - 1)
                    {
                        prev = currentNode;
                    }
                    else if (i == index)
                    {
                        newNode.next = currentNode;
                    }
                }
                prev.next = newNode;
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
                Node<T> currentNode = head;
                for (int i = 1; i < index + 1; ++i)
                {
                    currentNode = currentNode.next;
                }

                val = currentNode.value;
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

            Node<T> currentNode = head;
            for (int i = 0; i < Count; ++i)
            {
                if (currentNode.value.Equals(val))
                {
                    index = i;
                    break;
                }
                currentNode = currentNode.next;
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

                Node<T> currentNode = head.next;
                for (int i = 1; i < Count - 1; ++i)
                {
                    sb.Append(currentNode.value);
                    sb.Append(", ");
                    currentNode = currentNode.next;
                }
                if (currentNode != null)
                {
                    sb.Append(currentNode.value);
                }
            }

            return sb.ToString();
        }
    }
}
