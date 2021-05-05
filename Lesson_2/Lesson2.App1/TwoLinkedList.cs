using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.App1
{
    public class TwoLinkedList : ILinkedList
    {
        public int Count { get; set; }
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddNode(int value)
        {
            Node node = new Node { Value = value };
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.NextNode = node;
                node.PrevNode = Tail;
            }
            Tail = node;
            Count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            if (node == Tail)
            {
                AddNode(value);
            }
            else
            {
                Node newNode = new Node { Value = value };
                newNode.NextNode = node.NextNode;
                newNode.PrevNode = node.NextNode.PrevNode;
                node.NextNode.PrevNode = newNode;
                node.NextNode = newNode;
                Count++;
            }
        }

        public Node FindNode(int searchValue)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            return Count;
        }

        public void RemoveNode(int index)
        {
            int currentIndex = 0;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    RemoveNode(currentNode);
                    return;
                }
                currentIndex++;
                currentNode = currentNode.NextNode;
            }
        }

        public void RemoveNode(Node node)
        {
            if (node == Head)
            {
                Head = node.NextNode;
                node.NextNode = null;
                Head.PrevNode = null;
            }
            else if (node == Tail)
            {
                Tail = node.PrevNode;
                node.PrevNode = null;
                Tail.NextNode = null;
            }
            else
            {
                node.PrevNode.NextNode = node.NextNode;
                node.NextNode.PrevNode = node.PrevNode;
                node.PrevNode = null;
                node.NextNode = null;
            }
            Count--;
        }
    }
}
