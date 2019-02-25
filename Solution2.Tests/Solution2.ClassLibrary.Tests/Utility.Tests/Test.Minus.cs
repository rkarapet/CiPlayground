using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution2.ClassLibrary;

// ReSharper disable once CheckNamespace
namespace Solution2.Tests
{
    [TestClass]
    public class TestMinus
    {
        [TestMethod]
        public void ShouldReturn4()
        {
            const int expected = 4;
            int actual = Utility.Minus(6, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturn14()
        {
            const int expected = 14;
            int actual = Utility.Minus(28, 14);
            Assert.AreEqual(expected, actual);
        }
    }
}