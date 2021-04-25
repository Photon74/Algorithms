using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class Tree : ITree
    {
        public Node Root { get; private set; }        
        public int Count { get; private set; }

        public void AddItem(int value)
        {            
            var node = new Node { Value = value };
            if (Root == null)
            {
                Root = node;
                Count++;
                return;
            }
            
            var current = Root;
            while (current != null)
            {
                if (current.Value < node.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                    }
                    else
                    {
                        current = current.Left;
                        AddItem(value);
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                    }
                    else
                    {
                        current = current.Right;
                        AddItem(value);
                    }
                }
            }
            Count++;
        }

        public Node GetNodeByValue(int value)
        {
            throw new NotImplementedException();
        }

        public Node GetRoot()
        {
            throw new NotImplementedException();
        }

        public void PrintTree()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int value)
        {
            throw new NotImplementedException();
        }
    }
}
