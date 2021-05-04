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

        public Node GetNodeByValue(int nodeValue)
        {
            foreach (var node in Nodes)
            {
                if (node.Value == nodeValue)
                {
                    return node;
                }
            }
            return null;
        }

        public void AddEdge(int firstNodeValue, int secondNodeValue, int weight)
        {
            var firstNode = GetNodeByValue(firstNodeValue);
            var secondNode = GetNodeByValue(secondNodeValue);
            if (firstNode != null && secondNode != null)
            {
                firstNode.AddEdge(secondNode, weight);
                secondNode.AddEdge(firstNode, weight);
            }
        }
    }
}
