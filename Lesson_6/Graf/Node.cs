using System;
using System.Collections.Generic;
using System.Text;

namespace Graf
{
    public class Node
    {
        public int Value { get; set; }
        public List<Edge> Edges { get; set; }

        public Node(int value) // Создать вершину
        {
            Value = value;
            Edges = new List<Edge>();
        }

        public void AddEdge(Edge newEdge) // Добавить ребро
        {
            Edges.Add(newEdge);
        }

        public void AddEdge(Node node, int weight) // Добавить ребро
        {
            AddEdge(new Edge(node, weight));
        }

        public override string ToString() => Value.ToString();
    }
}
