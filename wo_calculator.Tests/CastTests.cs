using Microsoft.VisualStudio.TestTools.UnitTesting;
using wo_calculator.Logic;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Tests
{
    [TestClass]
    public class CastTest
    {
        [TestMethod]
        public void SystemTypeChangeTest()
        {
            var calculator = new Calculator();

            calculator.SystemType = SystemType.Oct;
            // Start value (should be trimmed to 455)
            calculator.InputValue = "4559";
            
            // Change to HEX
            calculator.SystemType = SystemType.Hex;
            Assert.AreEqual("12D", calculator.InputValue);

            // Change to decimal
            calculator.SystemType = SystemType.Dec;
            Assert.AreEqual("301", calculator.InputValue);
            
            // Change to Bin
            calculator.SystemType = SystemType.Bin;
            Assert.AreEqual("100101101", calculator.InputValue);
        }

        [TestMethod]
        public void TrimTest()
        {
            var calculator = new Calculator();

            calculator.SystemType = SystemType.Dec;
            calculator.WordType = WordType.BYTE;

            calculator.InputValue = "291";
            
            Assert.AreEqual("35", calculator.InputValue);
        }
        
    }
}
