using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class Tree : ITree
    {
        public Node Root { get; private set; }
        public int Count { get; private set; }

        public Tree()
        {
            Root = null;
        }

        /// <summary>
        /// Создание дерева из коллекции
        /// </summary>
        /// <param name="collection"></param>
        public Tree(IEnumerable<int> collection)
        {
            AddRange(collection);
        }

        public void AddItem(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
                Count++;
                return;
            }
            else
            {
                var currentNode = Root;
                AddNode(currentNode, value);
            }

        }

        public void AddRange(IEnumerable<int> collection)
        {
            foreach (var value in collection)
            {
                AddItem(value);
                Count++;
            }
        }

        public Node GetNodeByValue(int value)
        {
            return SearchNode(Root, value);
        }

        public Node GetRoot()
        {
            return Root;
        }

        public void RemoveItem(int value)
        {
            var node = GetNodeByValue(value);

            if (node == null) return;

            Node currentNode;

            if (node == Root)
            {
                currentNode = node.Right ?? node.Left;

                while (currentNode.Left != null)
                {
                    currentNode = currentNode.Left;
                }

                int tmp = currentNode.Value;
                RemoveItem(tmp);
                node.Value = tmp;

                // Count--;
                // return;
            }

            if (node.Left == null && node.Right == null) // удаление листьев
            {
                if (node.Parent.Left == node) node.Parent.Left = null;

                if (node.Parent.Right == node) node.Parent.Right = null;

                // Count--;
            }

            else if (node.Left == null || node.Right == null)
            {
                if (node.Left == null) // Удаление узла, имеющего правое поддерево, но не имеющее левого поддерева
                {
                    if (node.Parent.Left == node)
                    {
                        node.Parent.Left = node.Right;
                    }
                    else
                    {
                        node.Parent.Right = node.Right;
                    }
                    node.Right.Parent = node.Parent;
                }
                else // Удаление узла, имеющего левое поддерево, но не имеющее правого поддерева
                {
                    if (node.Parent.Left == node)
                    {
                        node.Parent.Left = node.Left;
                    }
                    else
                    {
                        node.Parent.Right = node.Left;
                    }
                    node.Left.Parent = node.Parent;
                }
            }

            else // Удаление узла, имеющего и правое и левое поддерево
            {
                currentNode = node.Right;

                while (currentNode.Left != null)
                {
                    currentNode = currentNode.Left;
                }

                if (currentNode.Parent == node) // Если самый левый элемент является первым потомком
                {
                    currentNode.Left = node.Left;
                    node.Left.Parent = currentNode;
                    currentNode.Parent = node.Parent;
                    if (node == node.Parent.Left)
                    {
                        node.Parent.Left = currentNode;
                    }
                    else
                    {
                        node.Parent.Right = currentNode;
                    }
                }

                else // Если самый левый элемент НЕ является первым потомком
                {
                    if (currentNode.Right != null) currentNode.Right.Parent = currentNode.Parent;

                    currentNode.Parent.Left = currentNode.Right;
                    currentNode.Right = node.Right;
                    currentNode.Left = node.Left;
                    node.Left.Parent = currentNode;
                    node.Right.Parent = currentNode;
                    currentNode.Parent = node.Parent;
                    if (node == node.Parent.Left)
                    {
                        node.Parent.Left = currentNode;
                    }
                    else if (node == node.Parent.Right)
                    {
                        node.Parent.Right = currentNode;
                    }
                }
            }
            Count--;
        }
        
        public bool IsEmpty(Tree tree)
        {
            if (tree.Root == null) return true;
            return false;
        }

        public void PrintTree()
        {
            Node node = Root;
            Console.Write($"        __{ node.Value}__\n       /      \\\n      {node.Left.Value}        {node.Right.Value}\n     / \\      /  \\\n" +
                $"    {node.Left.Left.Value}   {node.Left.Right.Value}   {node.Right.Left.Value}   {node.Right.Right.Value}\n   /\n" +
                $"  {node.Left.Left.Left.Value}\n / \\\n{node.Left.Left.Left.Left.Value}   {node.Left.Left.Left.Right.Value}\n" +
                $" \\   \\\n  {node.Left.Left.Left.Left.Right.Value}   {node.Left.Left.Left.Left.Right.Value}");
        }

        public bool Contains(int value)
        {
            var currentNode = Root;
            while (currentNode != null)
            {
                switch (value.CompareTo(currentNode.Value))
                {
                    case -1:
                        currentNode = currentNode.Left;
                        break;
                    case 1:
                        currentNode = currentNode.Right;
                        break;
                    default: return true;
                }
            }
            return false;
        }

        public string ToString(Node node)
        {
            return node.Value.ToString();
        }

        public Node FindMaximum()
        {
            Node node = Root;
            while (node != null)
            {
                if (node.Right == null)
                {
                    return node;
                }
                node = node.Right;
            }
            return null;
        }

        public Node FindMinimum()
        {
            Node node = Root;
            while (node != null)
            {
                if (node.Left == null)
                {
                    return node;
                }
                node = node.Left;
            }
            return null;
        }

        private void AddNode(Node node, int value)
        {
            var newNode = new Node(value);
            while (node != null)
            {
                if (value > node.Value)
                {
                    if (node.Right != null)
                    {
                        node = node.Right;
                    }
                    else
                    {
                        newNode.Parent = node;
                        node.Right = newNode;
                        break;
                    }
                }
                else
                {
                    if (node.Left != null)
                    {
                        node = node.Left;
                    }
                    else
                    {
                        newNode.Parent = node;
                        node.Left = newNode;
                        break;
                    }
                }
            }
            Count++;
        }

        private Node SearchNode(Node node, int value)
        {
            if (node == null) return null;

            return value.CompareTo(node.Value) switch
            {
                1 => SearchNode(node.Right, value),
                -1 => SearchNode(node.Left, value),
                0 => node,
                _ => null,
            };
        }

        //private Node Next(Node node)
        //{
        //    if (node.Right != null)
        //    {
        //        return FindMinimum(node.Right);
        //    }
        //    var y = node.Parent;
        //    while (y != null && node == y.Right)
        //    {
        //        node = y;
        //        y = y.Parent;
        //    }
        //    return y;
        //}

        //private Node Previous(Node node)
        //{
        //    if (node.Left != null)
        //    {
        //        return FindMaximum(node.Left);
        //    }
        //    var y = node.Parent;
        //    while (y != null && node == y.Left)
        //    {
        //        node = y;
        //        y = y.Parent;
        //    }
        //    return y;
        //}
    }
}
