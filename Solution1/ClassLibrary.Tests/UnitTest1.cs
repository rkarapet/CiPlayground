using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;


namespace ClassLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int actual = Utility.Divide(8, 4); 
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int actual = Utility.Divide(8, 2);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int actual = Utility.Divide(8, 8);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int actual = Utility.Divide(8, 9);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int actual = Utility.Divide(8, 9);
            Assert.AreEqual(0, actual);
        }
    }
}
