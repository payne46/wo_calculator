using Microsoft.VisualStudio.TestTools.UnitTesting;
using wo_calculator.Logic;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Tests
{
    [TestClass]
    public class TrimTest
    {
        [TestMethod]
        public void PasteTrimTest()
        {
            var calculator = new Calculator();

            calculator.SystemType = SystemType.Dec;
            calculator.WordType = WordType.BYTE;

            calculator.InputValue = "291";

            Assert.AreEqual("35", calculator.InputValue);


            calculator.InputValue = "300";

            Assert.AreEqual("44", calculator.InputValue);
        }

        [TestMethod]
        public void TrimTestBinary()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Bin
            };

            calculator.InputValue = "1111011010110111010100001010101100101011110001000111000111000111";

            calculator.WordType = WordType.DWORD;
            Assert.AreEqual("101011110001000111000111000111", calculator.InputValue);
            
            calculator.WordType = WordType.WORD;
            Assert.AreEqual("111000111000111", calculator.InputValue);

            calculator.WordType = WordType.BYTE;
            Assert.AreEqual("11000111", calculator.InputValue);
        }

        [TestMethod]
        public void TrimTestDec()
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Bin
            };

            calculator.InputValue = "11110110101101110101000010101011 00101011110001000111000111000111";
            calculator.SystemType = SystemType.Dec;
            Assert.AreEqual("-668977323537305145", calculator.InputValue);

            calculator.WordType = WordType.DWORD;
            Assert.AreEqual("734294471", calculator.InputValue);
           

        }

    }
}
