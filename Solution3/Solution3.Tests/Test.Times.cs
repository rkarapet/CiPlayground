using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution3.ConsoleApp;

namespace Solution3.Tests
{
    [TestClass]
    public class TestTimes
    {
        [TestMethod]
        public void _2Times2Returns4()
        {
            const int expected = 4;
            int actual = Program.Times(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _7Times7Returns49()
        {
            const int expected = 49;
            int actual = Program.Times(7, 7);
            Assert.AreEqual(expected, actual);
        }
    }
}
