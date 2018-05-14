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

        public void AddRange(IEnumerable<T> list)
        {
            for (int i = 0; i < list.Count(); ++i)
            {
                Add(list.ElementAt(i));
            }
        }

        public void Add(T value)
        {
            BinaryNode<T> newNode = new BinaryNode<T>();
            newNode.value = value;

            if (root == null)
            {
                root = newNode;
                Count = 1;
            }
            else
            {
                AddNode(root, newNode);
            }
        }

        private void AddNode(BinaryNode<T> curr, BinaryNode<T> node)
        {
            if (curr.value.CompareTo(node.value) <= 0)
            {
                if (curr.right == null)
                {
                    curr.right = node;
                    Count++;
                }
                else
                    AddNode(curr.right, node);
            }
            else
            {
                if (curr.left == null)
                {
                    curr.left = node;
                    Count++;
                }
                else
                    AddNode(curr.left, node);
            }
        }

        public void Remove(T value)
        {
            TraverseType type = TraverseType.LEFT;
            BinaryNode<T> parent = null;
            BinaryNode<T> removedNode = null;
            FindNode(value, root, ref removedNode, ref parent, ref type);
            BinaryNode<T> replaceParent = null;
            BinaryNode<T> replacementNode = null;

            if (removedNode != null)
            {
                Count--;

                if (removedNode.left == null)
                    GetReplacementNode(removedNode.right, ref replacementNode, ref replaceParent);
                else
                    GetReplacementNode(removedNode.left, ref replacementNode, ref replaceParent);

                if (replacementNode == null)
                    replacementNode = removedNode.right;
                if (replacementNode == null)
                {
                    if (type == TraverseType.LEFT)
                        parent.left = null;
                    else
                        parent.right = null;
                }
                else
                {
                    if (parent != null)
                    {
                        if (type == TraverseType.LEFT)
                            parent.left = replacementNode;
                        else
                            parent.right = replacementNode;
                    }
                    if (replaceParent != null)
                        replaceParent.right = replacementNode.right == null ? replacementNode.left : replacementNode.right;
                    replacementNode.left = null;
                    replacementNode.right = null;
                    if (replacementNode != null)
                    {
                        if (removedNode.left != replacementNode) replacementNode.left = removedNode.left;
                        if (removedNode.right != replacementNode) replacementNode.right = removedNode.right;
                    }

                    if (removedNode == root)
                    {
                        root = replacementNode;
                    }
                }
            }
        }

        private void FindNode(T value, BinaryNode<T> curr, ref BinaryNode<T> node, ref BinaryNode<T> parent, ref TraverseType type)
        {
            if (curr == null)
                return;

            if (curr.value.Equals(value))
            {
                node = curr;
                return;
            }

            if (curr.left != null && curr.left.value.Equals(value))
            {
                parent = curr;
                type = TraverseType.LEFT;
            }
            else if (curr.right != null && curr.right.value.Equals(value))
            {
                parent = curr;
                type = TraverseType.RIGHT;
            }
            
            FindNode(value, curr.left, ref node, ref parent, ref type);
            FindNode(value, curr.right, ref node, ref parent, ref type);
        }

        private void GetReplacementNode(BinaryNode<T> curr, ref BinaryNode<T> replace, ref BinaryNode<T> parent)
        {
            if (curr == null)
                return;

            if (curr.right != null && curr.right.right == null)
            {
                parent = curr;
            }

            if (curr.right == null)
            {
                replace = curr;
                return;
            }

            GetReplacementNode(curr.right, ref replace, ref parent);
        }

        public bool Contains(T value)
        {
            bool contains = false;

            HasValue(value, root, ref contains);

            return contains;
        }

        private void HasValue(T value, BinaryNode<T> curr, ref bool found)
        {
            if (found || curr == null)
                return;

            if (curr.value.Equals(value))
            {
                found = true;
                return;
            }

            HasValue(value, curr.left, ref found);
            HasValue(value, curr.right, ref found);
        }

        public void Clear()
        {
            root = null;
            Count = 0;
        }

        public string InOrder()
        {
            StringBuilder sb = new StringBuilder();

            if (root != null)
            {
                InOrderTraverse(root.left, sb, TraverseType.LEFT);
                sb.Append($"{root.value}, ");
                InOrderTraverse(root.right, sb, TraverseType.RIGHT);

                string s = sb.ToString();
                return s.Remove(s.Length - 2);
            }
            else
            {
                return "";
            }
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

            if (root != null)
            {
                sb.Append($"{root.value}");
                PreOrderTraverse(root.left, sb, TraverseType.LEFT);
                PreOrderTraverse(root.right, sb, TraverseType.RIGHT);
            }

            return sb.ToString();
        }

        private void PreOrderTraverse(BinaryNode<T> node, StringBuilder sb, TraverseType type)
        {
            if (node == null)
                return;

            sb.Append($", {node.value}");
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

            if (root != null)
            {
                PostOrderTraverse(root.left, sb, TraverseType.LEFT);
                PostOrderTraverse(root.right, sb, TraverseType.RIGHT);
                sb.Append($"{root.value}");
            }

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

            if (root != null)
            {
                height = 1;
                TraverseTheDepthsExplorer(ref height, 0, root);
            }

            return height;
        }

        private void TraverseTheDepthsExplorer(ref int maxHeight, int currentHeight, BinaryNode<T> curr)
        {
            if (curr == null)
                return;

            currentHeight++;
            if (currentHeight > maxHeight)
                maxHeight = currentHeight;

            TraverseTheDepthsExplorer(ref maxHeight, currentHeight, curr.left);
            TraverseTheDepthsExplorer(ref maxHeight, currentHeight, curr.right);
        }

        public T[] ToArray()
        {
            T[] values = new T[Count];

            int currentIndex = 0;
            AddNodes(root.left, values, ref currentIndex, TraverseType.LEFT);
            values[currentIndex++] = root.value;
            AddNodes(root.right, values, ref currentIndex, TraverseType.RIGHT);

            return values;
        }

        private void AddNodes(BinaryNode<T> node, T[] values, ref int currentIndex, TraverseType type)
        {
            if (node == null)
                return;

            if (type == TraverseType.LEFT)
            {
                AddNodes(node.left, values, ref currentIndex, type);
                values[currentIndex++] = node.value;
                AddNodes(node.right, values, ref currentIndex, type);
            }
            else
            {
                AddNodes(node.right, values, ref currentIndex, type);
                values[currentIndex++] = node.value;
                AddNodes(node.left, values, ref currentIndex, type);
            }
        }
    }
}
