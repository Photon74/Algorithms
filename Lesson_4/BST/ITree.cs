using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    interface ITree
    {
        Node GetRoot();
        void AddItem(int value); // добавить узел
        void RemoveItem(int value); // удалить узел по значению
        Node GetNodeByValue(int value); //получить узел дерева по значению
        void PrintTree(); //вывести дерево в консоль

    }
}
