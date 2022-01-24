using Microsoft.VisualStudio.TestTools.UnitTesting;
using wo_calculator.Logic;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Tests
{
    [TestClass]
    public class InputTestsOct
    {

        [TestMethod]
        public void SignTest()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Oct
            };

            calculator.InputValue = "123xd";

            Assert.AreEqual("123", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZeroPlus()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Oct
            };

            calculator.InputValue = "0s93g+2s45cl";

            Assert.AreEqual("3245", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZeroMinus()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Oct
            };

            calculator.InputValue = "0s93g2s45-cl";

            Assert.AreEqual("3245", calculator.InputValue);
        }
    }
}
