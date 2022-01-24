namespace wo_calculator.Logic.Converters
{
    public class WordConverter
    {
        public WordResult Convert(string value)
        {

            return new WordResult();
        }

    }

    public class WordResult
    {
        public string BinaryValue { get; set; }
        public string OctValue { get; set; }
        public string DecValue { get; set; }
        public string HexValue { get; set; }
    }

}
