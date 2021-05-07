using NUnit.Framework;
using Graf;

namespace TestsGraf
{
    public class Tests
    {
        GrafClass graf;
        [SetUp]
        public void Setup()
        {
            graf = new GrafClass(new[] { 10, 7, 12, 11, 6, 14, 13, 5 });
            graf.AddEdge(10, 12, 1);
            graf.AddEdge(10, 7, 1);
            graf.AddEdge(7, 11, 1);
            graf.AddEdge(12, 11, 1);
            graf.AddEdge(7, 6, 1);
            graf.AddEdge(12, 14, 1);
            graf.AddEdge(6, 13, 1);
            graf.AddEdge(14, 13, 1);
            graf.AddEdge(6, 5, 1);
            graf.AddEdge(14, 5, 1);
        }

        [Test]
        public void Graf_BFS_Test()
        {
            string actual = graf.BFS(10);
            string expected = "10 12 7 11 14 6 13 5 ";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Graf_DFS_Test()
        {
            string actual = graf.DFS(10);
            string expected = "10 7 6 5 14 13 11 12 ";

            Assert.AreEqual(expected, actual);
        }
    }
}