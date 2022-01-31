using System;
using System.Linq;
using System.Text;
using System.Threading;
using wo_calculator.Logic.Enums;
using wo_calculator.Logic.Helpers;

namespace wo_calculator.Logic.Converters
{

    public class ValueConverter
    {
        public string GetBinaryValue(string value, SystemType type, WordType w_len)
        {
            if (string.IsNullOrEmpty(value))
                return "0";
            return Convert.ToString(Convert.ToInt64(value, (int)type), 2); // 123D+231

        }

        public string ConvertValue(string value, SystemType oldType, SystemType newType, WordType w_len)
        {

            var parsedValueOld = this.GetParsedValue(value, oldType);

            var binaryValue = this.GetBinaryValue(parsedValueOld, oldType, w_len);
            
            binaryValue = this.ChangeBinaryLength(binaryValue, w_len);

            if (newType == SystemType.Bin)
                return binaryValue.TrimStart(new char[] { '0' });
            string tmp = binaryValue[0] == '1' && binaryValue.Length == (int)w_len ?
                new string('1', 64 - binaryValue.Length) + binaryValue : binaryValue;
            var converted = Convert.ToInt64(tmp, 2);

            switch (w_len)
            {
                case WordType.BYTE:
                    return Convert.ToString(Convert.ToSByte(converted), (int)newType).ToUpper();
                case WordType.WORD:
                    return Convert.ToString(Convert.ToInt16(converted), (int)newType).ToUpper();

                case WordType.DWORD:
                    return Convert.ToString(Convert.ToInt32(converted), (int)newType).ToUpper();
            }
            return Convert.ToString(converted, (int)newType).ToUpper();

        }

        public string ChangeBinaryLength(string binaryValue, WordType w_len)
        {
            var targetLength = (int)w_len;
            if (binaryValue.Length > targetLength)
            {
                return binaryValue.Substring(binaryValue.Length - targetLength);
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

            return this.ParseValue(value, AssignableValues.DecValues, type);
        }
        
        public string Get64BinaryValue(string value)
        {
            var parsed = this.ParseValue(value.TrimStart('-'), AssignableValues.BinaryValues);

            return new string('0', 64 - parsed.Length) + parsed;

        }

        public string ParseValue(string value, char[] availableChars, SystemType type = SystemType.Bin)
        {
            var sb = new StringBuilder();
            if (value[0] == '-' && SystemType.Dec == type)
                sb.Append('-');
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
