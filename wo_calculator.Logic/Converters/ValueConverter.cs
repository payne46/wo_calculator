using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wo_calculator.Logic.Enums;
using wo_calculator.Logic.Helpers;

namespace wo_calculator.Logic.Converters
{
    public class ValueConverter
    {
        public string GetValue(string value, SystemType type)
        {
            if (type == SystemType.Bin)
                return this.GetBinaryValue(value);

            if (type == SystemType.Dec)
                return this.GetDecValue(value);

            if (type == SystemType.Hex)
                return this.GetHexValue(value);

            return this.GetOctValue(value);
        }
        
        public string GetActiveValue(int value, SystemType type)
        {
            if (type == SystemType.Dec)
            {
                return value.ToString();
            }

            if (type == SystemType.Hex)
            {
                return value.ToString("X");
            }

            if (type == SystemType.Bin)
            {
                // todo
            }

            return Convert.ToInt64(value.ToString(), 8).ToString();
        }
        
        public string GetBinaryValue(string value)
        {
            return this.GetParsedValue(value, AssignableValues.BinaryValues);

        }

        public string Get64BinaryValue(string value)
        {
            var parsed = this.GetBinaryValue(value);

            var add = 64 - parsed.Length;

            return new string('0', add) + parsed;

        }

        public string GetOctValue(string value)
        {
            return this.GetParsedValue(value, AssignableValues.OctValues);
        }

        public string GetDecValue(string value)
        {
            return this.GetParsedValue(value, AssignableValues.DecValues);
        }

        public string GetHexValue(string value)
        {
            return this.GetParsedValue(value, AssignableValues.HexValues);
        }

        public string GetParsedValue(string value, char[] availableChars)
        {
            var sb = new StringBuilder();

            foreach (var v in value)
            {
                if (availableChars.Contains(v) || AssignableValues.CommonChars.Contains(v))
                {
                    sb.Append(v);
                }
            }

            return sb.ToString();
        }
        
    }
}
