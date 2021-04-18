using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.App1
{
    class Node
    {
        public int Value { get; set; }
        public TwoLinkedList NextNode { get; set; }
        public TwoLinkedList PrevNode { get; set; }
    }
}
