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
        }

        public Node GetNodeByValue(int value)
        {
            throw new NotImplementedException();
        }

        public Node GetRoot()
        {
            return Root;
        }

        public void PrintTree()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int value)
        {
            var nodeToDelete = GetNodeByValue(value);
            var p = nodeToDelete.Parent;
            if (nodeToDelete.Left == null && nodeToDelete.Right == null)
            {
                if (p.Left == nodeToDelete)
                {
                    p.Left = null;
                }
                if (p.Right == nodeToDelete)
                {
                    p.Right = null;
                }
            }
            else if (nodeToDelete.Left == null || nodeToDelete.Right == null)
            {
                if (nodeToDelete.Left == null)
                {
                    if (p.Left == nodeToDelete)
                    {
                        p.Left = nodeToDelete.Right;
                    }
                    else
                    {
                        p.Right = nodeToDelete.Right;
                    }
                    nodeToDelete.Right.Parent = p;
                }
                else
                {
                    if (p.Left == nodeToDelete)
                    {
                        p.Left = nodeToDelete.Left;
                    }
                    else
                    {
                        p.Right = nodeToDelete.Left;
                    }
                    nodeToDelete.Left.Parent = p;
                }
            }
            else
            {

            }
        }

        private Node Next(Node node)
        {
            if (node.Right != null)
            {
                return Minimum(node.Right);
            }
            var y = node.Parent;
            while (y != null && node == y.Right)
            {
                node = y;
                y = y.Parent;
            }
            return y;
        }

        private Node Previous(Node node)
        {
            if (node.Left != null)
            {
                return Maximum(node.Left);
            }
            var y = node.Parent;
            while (y != null && node == y.Left)
            {
                node = y;
                y = y.Parent;
            }
            return y;
        }

        private Node Maximum(Node left)
        {
            throw new NotImplementedException();
        }

        private Node Minimum(Node right)
        {
            throw new NotImplementedException();
        }
    }
}
