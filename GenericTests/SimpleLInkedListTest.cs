using GenericExercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTests
{
    [TestClass]
    public class SimpleLInkedListTest
    {

        private SimpleLinkedList<int> Create123List()
        {
            var list = new SimpleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            return list;
        }

        private SimpleLinkedList<string> CreateBlahBlihBlohList()
        {
            var list = new SimpleLinkedList<string>();
            list.Add("blah");
            list.Add("blih");
            list.Add("bloh");
            return list;
        }

        [TestMethod]
        public void EmptyList()
        {
            var list = new SimpleLinkedList<string>();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void AddThreeTimes()
        {
            var list = Create123List();
            Assert.AreEqual(list.Count, 3);
            Assert.AreEqual(list.GetElementAt(0), 1);
            Assert.AreEqual(list.GetElementAt(1), 2);
            Assert.AreEqual(list.GetElementAt(2), 3);
        }

        [TestMethod]
        public void AddInFront()
        {
            var list = CreateBlahBlihBlohList();
            list.Add("bluh", true);
            Assert.AreEqual(list.Count, 4);
            Assert.AreEqual(list.GetElementAt(0), "bluh");
            Assert.AreEqual(list.GetElementAt(1), "blah");
            Assert.AreEqual(list.GetElementAt(2), "blih");
            Assert.AreEqual(list.GetElementAt(3), "bloh");
        }

        [TestMethod]
        public void InsertAt()
        {
            var list = Create123List();
            list.InsertAt(2, 42);
            Assert.AreEqual(list.Count, 4);
            Assert.AreEqual(list.GetElementAt(0), 1);
            Assert.AreEqual(list.GetElementAt(1), 2);
            Assert.AreEqual(list.GetElementAt(2), 42);
            Assert.AreEqual(list.GetElementAt(3), 3);
        }

        [TestMethod]
        public void InsertAfter()
        {
            var list = CreateBlahBlihBlohList();

            var blihNode = list.GetNodeAt(1);
            Assert.AreEqual(blihNode.Value, "blih");

            list.InsertAfter(blihNode, "bluh");

            Assert.AreEqual(list.Count, 4);
            Assert.AreEqual(list.GetElementAt(0), "blah");
            Assert.AreEqual(list.GetElementAt(1), "blih");
            Assert.AreEqual(list.GetElementAt(2), "bluh");
            Assert.AreEqual(list.GetElementAt(3), "bloh");
        }

        [TestMethod]
        public void InsertBefore()
        {
            var list = Create123List();
            var node2 = list.GetNodeAt(1);
            Assert.AreEqual(node2.Value, 2);

            list.InsertBefore(node2, 42);
            Assert.AreEqual(list.Count, 4);
            Assert.AreEqual(list.GetElementAt(0), 1);
            Assert.AreEqual(list.GetElementAt(1), 42);
            Assert.AreEqual(list.GetElementAt(2), 2);
            Assert.AreEqual(list.GetElementAt(3), 3);
        }

        [TestMethod]
        public void RemoveAt()
        {
            var list = CreateBlahBlihBlohList();

            list.RemoveAt(1);

            Assert.AreEqual(list.Count, 2);
            Assert.AreEqual(list.GetElementAt(0), "blah");
            Assert.AreEqual(list.GetElementAt(1), "bloh");
        }

        [TestMethod]
        public void Remove()
        {
            var list = Create123List();
            var node2 = list.GetNodeAt(1);
            Assert.AreEqual(node2.Value, 2);

            list.Remove(node2);

            Assert.AreEqual(list.Count, 2);
            Assert.AreEqual(list.GetElementAt(0), 1);
            Assert.AreEqual(list.GetElementAt(1), 3);
        }

        [TestMethod]
        public void IEnumerableTest()
        {
            var list = CreateBlahBlihBlohList();
            Assert.IsTrue(list.SequenceEqual(new[] {"blah", "blih", "bloh"}));
        }
    }
}
