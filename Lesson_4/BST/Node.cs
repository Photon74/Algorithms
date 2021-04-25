using System;

namespace BST
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            var node = obj as Node;

            if (node == null)
                return false;

            return node.Value == Value;
        }
    }
}
