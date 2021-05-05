using Lesson2.App1;
using NUnit.Framework;

namespace Lesson2.Tests
{
    class TwoLinkedListTests
    {
        TwoLinkedList list;

        [SetUp]
        public void Setup()
        {
            list = new TwoLinkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
        }

        [Test]
        public void AddNote_Test()
        {
            list.AddNode(53);

            int actual = list.Tail.Value;
            int expected = 53;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddNodeAfterAndFindNode_Test()
        {
            list.AddNodeAfter(list.FindNode(2), 74);

            int actual = list.FindNode(2).NextNode.Value;
            int expected = 74;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Count_Test()
        {
            list.AddNode(45);
            list.AddNode(26);

            int actual = list.GetCount();
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveNodeByIndex_Test()
        {
            list.AddNodeAfter(list.FindNode(1), 666);
            list.RemoveNode(2);

            int actual = list.Tail.PrevNode.Value;
            int expected = 666;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveNode_Test()
        {
            list.RemoveNode(list.Head);

            int actual = list.Head.Value;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
