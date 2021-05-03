using System;
using System.Collections.Generic;
using BST;

namespace BFS
{
    class Program
    {
        static Tree tree;
        static void Main(string[] args)
        {
            tree = new Tree();
            tree.AddItem(10);
            tree.AddItem(7);
            tree.AddItem(9);
            tree.AddItem(12);
            tree.AddItem(6);
            tree.AddItem(14);
            tree.AddItem(11);
            tree.AddItem(3);
            tree.AddItem(4);
            tree.AddItem(8);
            tree.AddItem(1);
            tree.AddItem(5);
            tree.AddItem(2);
            tree.AddItem(13);

            BFS(100);
            Console.WriteLine("\n");
            DFS(100);

            Console.ReadLine();
        }

        public static Node BFS(int value)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(tree.Root);
            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();

                Console.Write(node.Value + " ");

                if (node.Value == value)
                {
                    return node;
                }
                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }
            return null;
        }

        public static Node DFS(int value)
        {
            var stack = new Stack<Node>();
            stack.Push(tree.Root);
            while (stack.Count != 0)
            {
                Node node = stack.Pop();

                Console.Write(node.Value + " ");

                if (node.Value == value)
                {
                    return node;
                }
                if (node.Right != null) stack.Push(node.Right);
                if (node.Left != null) stack.Push(node.Left);
            }
            return null;
        }
    }
}
