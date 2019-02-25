using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution2.ClassLibrary;

// ReSharper disable once CheckNamespace
namespace Solution2.Tests
{
    [TestClass]
    public class TestPlus
    {
        [TestMethod]
        public void ShouldReturn5()
        {
            const int expected = 5;
            int actual = Utility.Plus(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn11()
        {
            const int expected = 11;
            int actual = Utility.Plus(2, 9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn18()
        {
            const int expected = 11;
            int actual = Utility.Plus(17, 1);
            Assert.AreEqual(expected, actual);
        }
    }
}