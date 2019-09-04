using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc

{
    [TestClass]
    public class TestMethods
    {
        Calculator c;
        [TestInitialize]
        public void Init()
        {
           c = new Calculator();
        }
        [TestMethod]
        public void TestingDivide()
        {
            double result = c.Divide(8, 4);
                Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestingAdd()
        {
            Assert.AreEqual(13, c.Add(8, 5));
        }
        [TestMethod]
        public void TestingSubtract()
        {
            Assert.AreEqual(12, c.Subtract(15, 3));
        }
        [TestMethod]
        public void TestingMultiplication()
        {
            Assert.AreEqual(12, c.Multiply(6, 2));
        }
        [TestCleanup]
        public void Cleanup()
        {
            c = null;
        }
    }
}
