using System;
using System.Linq;
using System.Text;
using wo_calculator.Logic.Enums;
using wo_calculator.Logic.Helpers;

namespace wo_calculator.Logic.Converters
{

    public class ValueConverter
    {
        public string GetBinaryValue(string value, SystemType type, WordType w_len)
        {
            return w_len == WordType.QWORD
                ? Convert.ToString(Convert.ToInt64(value, (int)type), 2)
                : Convert.ToString(Convert.ToInt32(value, (int)type), 2); // 123D+231
        }
        

        public string FromInput(string value, SystemType type, WordType w_len)
        {
            var parsedValue = this.GetParsedValue(value, type);

            var binaryValue = this.GetBinaryValue(parsedValue, type, w_len);

            if (type == SystemType.Bin)
                return binaryValue.TrimStart(new char[] { '0' });

            binaryValue = this.ChangeBinaryLength(binaryValue, w_len);

            var converted = Convert.ToInt32(binaryValue, 2);

            switch (type)
            {
                case SystemType.Oct:
                    return Convert.ToString(converted, 8);

                case SystemType.Dec:
                    return converted.ToString();

                case SystemType.Hex:
                    return converted.ToString("X");
            }

            return binaryValue.TrimStart(new char[] { '0' });
        }

        public string FromChange(string value, SystemType oldType, SystemType newType, WordType w_len)
        {
            if (oldType == newType)
                return this.FromInput(value, oldType, w_len);

            var parsedValueOld = this.GetParsedValue(value, oldType);

            var binaryValue = this.GetBinaryValue(parsedValueOld, oldType, w_len);
            
            if (newType == SystemType.Bin)
                return binaryValue.TrimStart(new char[] { '0' });

            binaryValue = this.ChangeBinaryLength(binaryValue, w_len);

            var converted = Convert.ToInt32(binaryValue, 2);

            switch (newType)
            {
                case SystemType.Oct:
                    return Convert.ToString(converted, 8);

                case SystemType.Dec:
                    return converted.ToString();

                case SystemType.Hex:
                    return converted.ToString("X");
            }

            return binaryValue.TrimStart(new char[] { '0' });
        }

        public string ChangeBinaryLength(string binaryValue, WordType w_len)
        {
            var targetLength = (int)w_len;

            if (binaryValue.Length > targetLength)
            {
                return binaryValue.Substring(binaryValue.Length - targetLength, targetLength);
            }

            if (binaryValue.Length < targetLength)
            {
                return new string('0', targetLength - binaryValue.Length) + binaryValue;
            }

            return binaryValue;
        }
        
        public string GetParsedValue(string value, SystemType type)
        {
            if (type == SystemType.Bin)
                return this.ParseValue(value, AssignableValues.BinaryValues);

            if (type == SystemType.Oct)
                return this.ParseValue(value, AssignableValues.OctValues);

            if (type == SystemType.Hex)
                return this.ParseValue(value, AssignableValues.HexValues);

            return this.ParseValue(value, AssignableValues.DecValues);
        }
        
        public string Get64BinaryValue(string value)
        {
            var parsed = this.ParseValue(value.TrimStart('-'), AssignableValues.BinaryValues);

            return new string('0', 64 - parsed.Length) + parsed;

        }

        public string ParseValue(string value, char[] availableChars)
        {
            var sb = new StringBuilder();

            foreach (var v in value)
            {
                if (availableChars.Contains(v))
                {
                    sb.Append(v);
                }
            }

            return sb.ToString();
        }
        
    }
}
