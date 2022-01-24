using Microsoft.VisualStudio.TestTools.UnitTesting;
using wo_calculator.Logic;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Tests
{
    [TestClass]
    public class InitTests
    {
        [TestMethod]
        public void TestCalculatorInit()
        {
            var calculator = new Calculator();

            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void TestCalculatorValueInit()
        {
            var calculator = new Calculator();
            
            Assert.AreEqual("0", calculator.InputValue);
        }
        
        [TestMethod]
        public void TestCalculatorSystemInit()
        {
            var calculator = new Calculator();

            Assert.AreEqual(SystemType.Dec, calculator.SystemType);
        }

        [TestMethod]
        public void TestCalculatorWordInit()
        {
            var calculator = new Calculator();

            Assert.AreEqual(WordType.QWORD, calculator.WordType);
        }

        [TestMethod]
        public void TestCalculatorBinaryValue()
        {
            var calculator = new Calculator();
            
            Assert.AreEqual(calculator.BinaryValue.Length, 64);

            foreach (var c in calculator.BinaryValue)
            {
                Assert.AreEqual('0', c);
            }
        }

    }
}
