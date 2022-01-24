using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wo_calculator.Logic;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Tests
{

    [TestClass]
    public class InputTestsHex
    {

        [TestMethod]
        public void SignTest()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Hex
            };

            calculator.InputValue = "123xd";

            Assert.AreEqual("123d", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZeroPlus()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Hex
            };

            calculator.InputValue = "0s93g+2s45cl";

            Assert.AreEqual("093+245c", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZeroMinus()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Hex
            };

            calculator.InputValue = "0s93g2s45-cl";

            Assert.AreEqual("093245-c", calculator.InputValue);
        }
    }
}
