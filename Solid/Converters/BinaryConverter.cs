using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Converters
{
    public class BinaryConverter : Converter, IConverter
    {
        public BinaryConverter(int decimalNumber) : base(decimalNumber)
        {
        }

        public override string Convert()
        {
            return $"The result is: {System.Convert.ToString(DecimalNumber, 2)}";
        }

        public string BinaryToText(string binary)
        {
            binary = binary.Replace(" ", "");
            var list = new List<Byte>();

            foreach (var item in list)
            {
            }
        }

        public string HexadecimalToText(string text)
        {
            throw new NotImplementedException();
        }

        public string TextToBinary(string text)
        {
            throw new NotImplementedException();
        }

        public string TextToHexadecimal(string text)
        {
            throw new NotImplementedException();
        }
    }
}