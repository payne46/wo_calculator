using System;
using System.Runtime.InteropServices;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Logic
{
    public class Calculator
    {
        private int activeValue;
        private string inputValue;

        public Calculator()
        {
            this.InputValue = "0";
            this.ActiveValue = "0";
            this.SystemType = SystemType.Dec;
            this.WordType = WordType.QWORD;

            this.BinaryValue = new int[64];
            for (int i = 0; i < 64; i++)
            {
                this.BinaryValue[i] = 0;
            }
        }

        public string InputValue
        {
            get { return this.inputValue; }
            set
            {
                this.inputValue = this.Parse(value);
            }
        }

        private string Parse(string value)
        {
            return string.Empty;
        }

        public int[] BinaryValue { get; set; }

        private string GetActiveValue(int activeValue, SystemType type) 
        {
            if (type == SystemType.Dec)
            {
                return activeValue.ToString();
            }

            if (type == SystemType.Hex)
            {
                return activeValue.ToString("X");
            }

            if (type == SystemType.Bin)
            {
                // todo
            }

            return Convert.ToInt64(activeValue.ToString(), 8).ToString();
        }

        private int ConvertToActiveValue(string activeValue, SystemType type)
        {
            this.BinaryValue = this.BitActiveValue(activeValue, type);

            if (type == SystemType.Dec)
            {
                return int.Parse(activeValue);
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
        
        public string ActiveValue
        {
            get
            {
                return this.GetActiveValue(this.activeValue, this.SystemType);
            }
            set
            {
                this.activeValue = this.ConvertToActiveValue(value, this.SystemType);
            }
        }

        public SystemType SystemType { get; set; }

        public WordType WordType { get; set; }

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
