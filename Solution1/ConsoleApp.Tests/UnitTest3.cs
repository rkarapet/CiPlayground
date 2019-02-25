using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.Add(7, 7);
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = Program.Add(6, 6);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = Program.Add(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int result = Program.Add(9, 9);
            Assert.AreEqual(18, result);
        }
    }
}
