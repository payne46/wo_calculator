using Microsoft.VisualStudio.TestTools.UnitTesting;
using wo_calculator.Logic;

namespace wo_calculator.Tests
{
    [TestClass]
    public class InputTestsBinary
    {

        [TestMethod]
        public void SignTestOne()
        {
            var calculator = new Calculator();

            Assert.AreEqual("1011", calculator.GetBinaryValue("1g0d11f"));
        }

        [TestMethod]
        public void SignTestZero()
        {
            var calculator = new Calculator();

            Assert.AreEqual("001", calculator.GetBinaryValue("0g01h3s"));
        }
    }
}
