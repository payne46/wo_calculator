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
                SystemType = SystemType.Oct
            };

            calculator.InputValue = "4559";

            calculator.SystemType = SystemType.Hex;

            var value = calculator.InputValue;
        }
    }
}
