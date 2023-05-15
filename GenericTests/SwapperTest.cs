using GenericExercices;

namespace GenericTests
{
    [TestClass]
    public class SwapperTest
    {
        [TestMethod]
        public void SwappReferencesInt()
        {
            var i = 42;
            var j = 666;

            Swapper.Swap(ref i, ref j);

            Assert.AreEqual(i, 666);
            Assert.AreEqual(j, 42);
        }

        [TestMethod]
        public void SwappReferencesString()
        {
            var i = "blah";
            var j = "bloh";

            Swapper.Swap(ref i, ref j);

            Assert.AreEqual(i, "bloh");
            Assert.AreEqual(j, "blah");
        }
    }
}