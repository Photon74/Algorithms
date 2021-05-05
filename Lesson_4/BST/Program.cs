using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
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

            tree.PrintTree();


            Console.ReadLine();
        }
    }
}
