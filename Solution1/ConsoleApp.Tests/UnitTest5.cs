using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.Multiply(11, 7);
            Assert.AreEqual(77, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = Program.Multiply(11, 8);
            Assert.AreEqual(88, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = Program.Multiply(11, 2);
            Assert.AreEqual(22, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int result = Program.Multiply(11, 3);
            Assert.AreEqual(33, result);
        }
    }
}

