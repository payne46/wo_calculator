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
            calculator.InputValue = "455";
            
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
        public void SystemTypeChangeTestMinus()
        {
            var calculator = new Calculator();
            calculator.WordType = WordType.QWORD;
            calculator.SystemType = SystemType.Dec;

            calculator.InputValue = "-1589";

            // Change to HEX
            calculator.SystemType = SystemType.Hex;
            Assert.AreEqual("FFFFFFFFFFFFF9CB", calculator.InputValue);
            
            // Change to OCT
            calculator.SystemType = SystemType.Oct;
            Assert.AreEqual("1777777777777777774713", calculator.InputValue);

            // Change to Bin
            calculator.SystemType = SystemType.Bin;
            Assert.AreEqual("1111111111111111111111111111111111111111111111111111100111001011", calculator.InputValue);

            // Change back to decimal
            calculator.SystemType = SystemType.Dec;
            Assert.AreEqual("-1589", calculator.InputValue);

        }

        [TestMethod]
        public void SystemTypeChangeTestMinus2()
        {
            var calculator = new Calculator();
            calculator.WordType = WordType.WORD;
            calculator.SystemType = SystemType.Dec;

            calculator.InputValue = "-107";

            // Change to HEX
            calculator.SystemType = SystemType.Hex;
            Assert.AreEqual("FF95", calculator.InputValue);

            // Change to OCT
            calculator.SystemType = SystemType.Oct;
            Assert.AreEqual("177625", calculator.InputValue);

            // Change to Bin
            calculator.SystemType = SystemType.Bin;
            Assert.AreEqual("1111111110010101", calculator.InputValue);

            // Change back to decimal
            calculator.SystemType = SystemType.Dec;
            Assert.AreEqual("-107", calculator.InputValue);

        }


    }
}
