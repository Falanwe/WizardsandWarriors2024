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

        [TestMethod]
        public void EmptyList()
        {
            var list = new SimpleLinkedList<string>();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void AddThreeTimes()
        {
            var list = new SimpleLinkedList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            Assert.AreEqual(list.Count, 3);
            Assert.AreEqual(list.GetElementAt(0), 0);
            Assert.AreEqual(list.GetElementAt(1), 1);
            Assert.AreEqual(list.GetElementAt(2), 2);
        }
    }
}
