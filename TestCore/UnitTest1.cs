using Library;

namespace TestCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new Calculator();

            Assert.AreEqual(5, calc.Add(2, 3));
            Assert.AreEqual(10, calc.Multiply(2, 5));
        }
    }
}