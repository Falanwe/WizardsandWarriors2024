using GenericExercices;
using System.Collections.Generic;

namespace GenericTests
{
    [TestClass]
    public class SwapperTest
    {
        [TestMethod]
        public void SwapReferenceInt()
        {
            var i = 42;
            var j = 666;

            Swapper.Swap(ref i, ref j);

            Assert.AreEqual(i, 666);
            Assert.AreEqual(j, 42);
        }

        [TestMethod]
        public void SwapReferenceString()
        {
            var i = "blah";
            var j = "bloh";

            Swapper.Swap(ref i, ref j);

            Assert.AreEqual(i, "bloh");
            Assert.AreEqual(j, "blah");
        }

        [TestMethod]
        public void SwapArrayInt()
        {
            var array = new[] { 0, 1, 2, 3, 4, 5 };
            Swapper.Swap(array, 2, 4);
            Assert.IsTrue(array.Length == 6);
            Assert.IsTrue(array.SequenceEqual(new[] { 0, 1, 4, 3, 2, 5 }));
        }

        [TestMethod]
        public void SwapArrayString()
        {
            var array = new[] { "0", "1", "2", "3", "4", "5" };
            Swapper.Swap(array, 2, 4);
            Assert.IsTrue(array.Length == 6);
            Assert.IsTrue(array.SequenceEqual(new[] { "0", "1", "4", "3", "2", "5" }));
        }

        [TestMethod]
        public void SwapListInt()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            Swapper.Swap(list, 2, 4);
            Assert.IsTrue(list.Count == 6);
            Assert.IsTrue(list.SequenceEqual(new[] { 0, 1, 4, 3, 2, 5 }));
        }

        [TestMethod]
        public void SwapListString()
        {
            var list = new SynchronizedCollection<string> { "0", "1", "2", "3", "4", "5" };
            Swapper.Swap(list, 2, 4);
            Assert.IsTrue(list.Count == 6);
            Assert.IsTrue(list.SequenceEqual(new[] { "0", "1", "4", "3", "2", "5" }));
        }
    }
}