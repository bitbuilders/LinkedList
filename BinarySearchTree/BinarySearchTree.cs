using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDataStructures
{
    public enum TraverseType
    {
        LEFT,
        RIGHT
    }

    public class BinarySearchTree<T> where T : IComparable
    {
        private BinaryNode<T> root = null;
        public int Count { get; private set; }

        public void Add(T value)
        {
            BinaryNode<T> newNode = new BinaryNode<T>();
            newNode.value = value;

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BinaryNode<T> currentNode = root;
                while (currentNode != null)
                {
                    if (currentNode.value.CompareTo(value) <= 0)
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                    else
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                }
            }

            Count++;
        }

        public void Remove(T value)
        {
            BinaryNode<T> parentNode;
            BinaryNode<T> removedNode;
            BinaryNode<T> replacementNode;
            
        }

        public bool Contains(T value)
        {
            bool contains = false;

            return contains;
        }

        public void Clear()
        {

        }

        public string InOrder()
        {
            StringBuilder sb = new StringBuilder();

            InOrderTraverse(root.left, sb, TraverseType.LEFT);
            sb.Append($"{root.value}, ");
            InOrderTraverse(root.right, sb, TraverseType.RIGHT);

            return sb.ToString();
        }

        private void InOrderTraverse(BinaryNode<T> node, StringBuilder sb, TraverseType type)
        {
            if (node == null)
                return;

            if (type == TraverseType.LEFT)
            {
                InOrderTraverse(node.left, sb, type);
                sb.Append($"{node.value}, ");
                InOrderTraverse(node.right, sb, type);
            }
            else
            {
                InOrderTraverse(node.right, sb, type);
                sb.Append($"{node.value}, ");
                InOrderTraverse(node.left, sb, type);
            }
        }

        public string PreOrder()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{root.value}, ");
            PreOrderTraverse(root.left, sb, TraverseType.LEFT);
            PreOrderTraverse(root.right, sb, TraverseType.RIGHT);

            return sb.ToString();
        }

        private void PreOrderTraverse(BinaryNode<T> node, StringBuilder sb, TraverseType type)
        {
            if (node == null)
                return;

            sb.Append($"{node.value}, ");
            if (type == TraverseType.LEFT)
            {
                PreOrderTraverse(node.left, sb, type);
                PreOrderTraverse(node.right, sb, type);
            }
            else
            {
                PreOrderTraverse(node.right, sb, type);
                PreOrderTraverse(node.left, sb, type);
            }
        }

        public string PostOrder()
        {
            StringBuilder sb = new StringBuilder();

            PostOrderTraverse(root.left, sb, TraverseType.LEFT);
            PostOrderTraverse(root.right, sb, TraverseType.RIGHT);
            sb.Append($"{root.value}, ");

            return sb.ToString();
        }

        private void PostOrderTraverse(BinaryNode<T> node, StringBuilder sb, TraverseType type)
        {
            if (node == null)
                return;

            if (type == TraverseType.LEFT)
            {
                PostOrderTraverse(node.left, sb, type);
                PostOrderTraverse(node.right, sb, type);
                sb.Append($"{node.value}, ");
            }
            else
            {
                PostOrderTraverse(node.right, sb, type);
                PostOrderTraverse(node.left, sb, type);
                sb.Append($"{node.value}, ");
            }
        }

        public int Height()
        {
            int height = 0;



            return height;
        }

        public T[] ToArray()
        {
            T[] values = new T[Count];



            return values;
        }
    }
}
