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
    public class WordTypeTests
    {

        [TestMethod]
        public void ByteTest1()
        {
            var calculator = new Calculator()
            {
                WordType = WordType.BYTE
            };

            calculator.InputValue = "129";
            
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

            Assert.AreEqual("03+245", calculator.InputValue);
        }

        [TestMethod]
        public void SignTestZeroMinus()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Oct
            };

            calculator.InputValue = "0s93g2s45-cl";

            Assert.AreEqual("03245-", calculator.InputValue);
        }
    }
}
