using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.Multiply(7, 7);
            Assert.AreEqual(49, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = Program.Multiply(6, 6);
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = Program.Multiply(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int result = Program.Multiply(9, 9);
            Assert.AreEqual(81, result);
        }
    }
}
