using NUnit.Framework;
using BST;

namespace TestsForBST
{
    public class Tests
    {
        Tree tree;
        int[] range = { 30, 25, 17 };

        [SetUp]
        public void Setup()
        {
            tree = new Tree();
            tree.AddItem(10);
            tree.AddItem(7);
            tree.AddItem(9);
            tree.AddItem(12);
            tree.AddItem(6);
            tree.AddItem(14); // max
            tree.AddItem(11);
            tree.AddItem(3);
            tree.AddItem(4);
            tree.AddItem(8);
            tree.AddItem(1); // min
            tree.AddItem(5);
            tree.AddItem(2);
            tree.AddItem(13);

        }

        [Test]
        public void GetRoot_Test()
        {
            int actual = tree.GetRoot().Value;
            int expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddRange_Test()
        {
            tree.AddRange(range);

            int actual = tree.Count;
            int expected = 17;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddItem_Test()
        {
            tree.AddItem(28);

            int actual = tree.Root.Right.Right.Right.Value;
            int expected = 28;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void Contains_Tests(int value)
        {
            bool condition = tree.Contains(value);

            Assert.IsTrue(condition);
        }

        [Test]
        public void FindMaximum_Test()
        {
            int ectual = tree.FindMaximum().Value;
            int expected = 14;

            Assert.AreEqual(expected, ectual);
        }

        [Test]
        public void FindMinimum_Test()
        {
            int ectual = tree.FindMinimum().Value;
            int expected = 1;

            Assert.AreEqual(expected, ectual);
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void GetNodeByValue_Test(int value)
        {
            Node node = tree.GetNodeByValue(value);

            Assert.IsNotNull(node);
        }

        [Test]
        public void RemoveItem_Test()
        {
            tree.RemoveItem(12);

            int actual = tree.GetRoot().Right.Value;
            int expected = 13;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Clear_And_IsEmpty_Test()
        {
            tree.Clear();

            bool condition = tree.IsEmpty(tree);

            Assert.IsTrue(condition);
        }
    }
}