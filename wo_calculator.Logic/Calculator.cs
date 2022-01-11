using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wo_calculator.Logic.Enums;

namespace wo_calculator.Logic
{
    public class Calculator
    {
        public Calculator()
        {
            this.InputValue = "0";
            this.ActiveValue = "0";
            this.SystemType = SystemType.Dec;
            this.WordType = WordType.QWORD;
        }
        

        public string InputValue { get; set; }

        public string ActiveValue { get; set; }

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
    }
}
