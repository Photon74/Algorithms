using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.App1
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
}
