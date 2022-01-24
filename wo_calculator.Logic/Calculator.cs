using System;
using wo_calculator.Logic.Converters;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Logic
{
    public class Calculator
    {
        private string inputValue;

        public ValueConverter Converter { get; set; }

        public Calculator()
        {
            this.Converter = new ValueConverter();

            this.SystemType = SystemType.Dec;
            this.WordType = WordType.QWORD;

            this.InputValue = "0";
        }

        public string InputValue
        {
            get { return this.inputValue; }
            set
            {
                this.inputValue = this.Converter.Shorten(this.Converter.GetValue(value, this.SystemType), this.SystemType, this.WordType);
            }
        }
        
        public string BinaryValue
        {
            get { return this.Converter.Get64BinaryValue(this.InputValue); }
        }

        public SystemType SystemType { get; set; }

        public WordType WordType { get; set; }
        
        private int ConvertToActiveValue(string value, SystemType type)
        {
            if (type == SystemType.Dec)
            {
                return int.Parse(value);
            }

            if (type == SystemType.Hex)
            {
                // todo
            }

            if (type == SystemType.Bin)
            {
                // todo
            }

            // todo OCT
            return -1;
        }
        
        public int[] BitActiveValue(string value, SystemType systemType = SystemType.Dec)
        {
            if (systemType == SystemType.Bin)
            {
                var valueLength = value.Length;
                var zeros = 64 - valueLength;

                var bit = new int[64];

                for (int i = 0; i < 64; i++)
                {
                    if (i <= zeros)
                        bit[i] = 0;

                    bit[i] = value[i - zeros];
                }

                return bit;
            }

            if (systemType == SystemType.Dec)
            {
                // todo
            }

            return null;
        }
        
        public int[] DecToBinary(int n)
        {
            // array to store binary number
            int[] binaryNum = new int[64];

            // counter for binary array
            int i = 0;
            while (n > 0)
            {
                // storing remainder in binary array
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }

            return binaryNum;
        }


        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Modulo(double x, double y)
        {
            return x % y;
        }

        public double ChangeSign(double x)
        {
            return x * (-1);
        }

        public string LeftShift(uint value, int bit)
        {
            uint x = value << bit;

            return Convert.ToString(x, toBase: 2);
        }

        public string RightShift(uint value, int bit)
        {
            uint x = value >> bit;

            return Convert.ToString(x, toBase: 2);
        }

        public string AndOperator(uint x, uint y)
        {
            uint z = x & y;

            return Convert.ToString(z, toBase: 2);
        }

        public string OrExOperator(uint x, uint y)
        {
            uint z = x ^ y;

            return Convert.ToString(z, toBase: 2);
        }
        
        public string OrOperator(uint x, uint y)
        {
            uint z = x | y;

            return Convert.ToString(z, toBase: 2);
        }

        public bool IsEqual(double x, double y)
        {
            return x == y;
        }
    }
}
