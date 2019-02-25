using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.Add(7, 5);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = Program.Add(5, 6);
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = Program.Add(2, 6);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int result = Program.Add(9, 4);
            Assert.AreEqual(13, result);
        }
    }
}
