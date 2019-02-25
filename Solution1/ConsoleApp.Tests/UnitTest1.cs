using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.Add(5, 5);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = Program.Add(5, 4);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = Program.Add(2, 5);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int result = Program.Add(3, 4);
            Assert.AreEqual(7, result);
        }
    }
}
