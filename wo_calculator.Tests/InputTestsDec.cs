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
    public class InputTestsDec
    {

        [TestMethod]
        public void SignTest()
        {
            var calculator = new Calculator();

            calculator.InputValue = "123xd";

            Assert.AreEqual("123", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZeroPlus()
        {
            var calculator = new Calculator();

            calculator.InputValue = "0s93g+2s45cl";

            Assert.AreEqual("93245", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZeroMinus()
        {
            var calculator = new Calculator();

            calculator.InputValue = "-0s93g2s45-cl";

            Assert.AreEqual("-93245", calculator.InputValue);
        }
    }
}
