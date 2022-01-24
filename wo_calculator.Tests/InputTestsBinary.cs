using Microsoft.VisualStudio.TestTools.UnitTesting;
using wo_calculator.Logic;
using wo_calculator.Logic.Converters;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Tests
{
    [TestClass]
    public class InputTestsBinary
    {

        [TestMethod]
        public void SignTestOne()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Bin
            };

            calculator.InputValue = "1g0d11f";

            Assert.AreEqual("1011", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZero()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Bin
            };

            calculator.InputValue = "0g01h3s";

            Assert.AreEqual("001", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZeroPlus()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Bin
            };

            calculator.InputValue = "+0g01h3s";

            Assert.AreEqual("+001", calculator.InputValue);
        }
        
        [TestMethod]
        public void SignTestZeroMinus()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Bin
            };

            calculator.InputValue = "-0g01h3s";

            Assert.AreEqual("-001", calculator.InputValue);
        }
    }
}
