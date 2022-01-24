using wo_calculator.Logic;
using wo_calculator.Logic.Converters;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator()
            {
                SystemType = SystemType.Bin
            };

            calculator.InputValue = "111101101011011101011010101100101011110001000111000111000111";

            calculator.WordType = WordType.DWORD;
            var result = string.Equals("00101011110001000111000111000111", calculator.InputValue);

            calculator.WordType = WordType.WORD;
            result = string.Equals("0111000111000111", calculator.InputValue);

            calculator.WordType = WordType.BYTE;
            result = string.Equals("11000111", calculator.InputValue);
        }
    }
}
