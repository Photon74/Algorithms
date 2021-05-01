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

            BFS(2);

            Console.ReadLine();
        }

        public static Node BFS(int value)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(tree.Root);
            while (queue.Count != 0)
            {
                foreach (var item in queue)
                {
                    Console.Write(item.Value + " ");
                }
                Console.WriteLine();

                Node node = queue.Dequeue();
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
            return null;
        }
    }
}
