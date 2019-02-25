using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;


namespace ClassLibrary.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int actual = Utility.Divide(12, 4);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int actual = Utility.Divide(8, 16);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int actual = Utility.Divide(15, 5);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int actual = Utility.Divide(16, 8);
            Assert.AreEqual(2, actual);
        }
    }
}
