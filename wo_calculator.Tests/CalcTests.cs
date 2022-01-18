using Microsoft.VisualStudio.TestTools.UnitTesting;
using wo_calculator.Logic;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void AddTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(0, calculator.Add(0, 0));
            Assert.AreEqual(30, calculator.Add(10, 20));
            Assert.AreEqual(50, calculator.Add(25, 25));

            Assert.AreEqual(10, calculator.Add(-25, 35));
            Assert.AreEqual(20, calculator.Add(-5, 25));
            Assert.AreEqual(30, calculator.Add(0, 30));

            Assert.AreEqual(0, calculator.Add(0, 0));
        }

        [TestMethod]
        public void SubtractTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(-10, calculator.Subtract(10, 20)); 
            Assert.AreEqual(-50, calculator.Subtract(33, 83)); 
            Assert.AreEqual(-4, calculator.Subtract(0, 4));
            
            Assert.AreEqual(13, calculator.Subtract(50, 37));
            Assert.AreEqual(23, calculator.Subtract(30, 7));
            Assert.AreEqual(33, calculator.Subtract(50, 17));

            Assert.AreEqual(0, calculator.Subtract(0, 0));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            
            Assert.AreEqual(1, calculator.Multiply(1, 1));
            Assert.AreEqual(5, calculator.Multiply(1, 5));
            Assert.AreEqual(25, calculator.Multiply(5, 5));
            Assert.AreEqual(64, calculator.Multiply(8, 8));
        }

        [TestMethod]
        public void DivideTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(1, calculator.Divide(1, 1));
            Assert.AreEqual(5, calculator.Multiply(1, 5));
            Assert.AreEqual(25, calculator.Multiply(5, 5));
            Assert.AreEqual(64, calculator.Multiply(8, 8));
        }
        
        [TestMethod]
        public void ModuloTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(1, calculator.Modulo(3, 2));
            Assert.AreEqual(1, calculator.Modulo(10, 3));
            Assert.AreEqual(4, calculator.Modulo(24, 5));
            Assert.AreEqual(4, calculator.Modulo(68, 8));
        }
        
        [TestMethod]
        public void ChangeSignTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(-3, calculator.ChangeSign(3));
            Assert.AreEqual(-53, calculator.ChangeSign(53));
            Assert.AreEqual(-113, calculator.ChangeSign(113));
            Assert.AreEqual(-343, calculator.ChangeSign(343));
            Assert.AreEqual(20, calculator.ChangeSign(-20));
            Assert.AreEqual(510, calculator.ChangeSign(-510));
        }

        [TestMethod]
        public void LeftShiftTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual("10010000000000000000000100010000", calculator.LeftShift(0b_1100_1001_0000_0000_0000_0000_0001_0001, 4));
        }


        [TestMethod]
        public void RightShiftTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual("10", calculator.RightShift(0b_1001, 2));
        }

        [TestMethod]
        public void LogicalAndTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual("10011000", calculator.AndOperator(0b_1111_1000, 0b_1001_1101));
        }

        [TestMethod]
        public void LogicalOrTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual("10110001", calculator.OrOperator(0b_1010_0000, 0b_1001_0001));
        }

        [TestMethod]
        public void LogicalOrExTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual("11100100", calculator.OrExOperator(0b_1111_1000, 0b_0001_1100));
        }

    }
}
