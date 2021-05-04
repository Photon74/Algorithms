using System;
using System.Collections.Generic;
using System.Text;

namespace Graf
{
    public class Graf
    {
        public List<Node> Nodes { get; }

        public Graf()
        {
            Nodes = new List<Node>();
        }

        public void AddNode(int nodeValue)
        {
            Nodes.Add(new Node(nodeValue));
        }


    }
}
