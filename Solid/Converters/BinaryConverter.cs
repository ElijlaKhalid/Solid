using Solid.IConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Converters
{
    public class BinaryConverter : Converter, IBinaryConverter
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

            for (int i = 0; i < binary.Length; i += 8)
            {
                string t = binary.Substring(i, 8);
                list.Add(System.Convert.ToByte(t, 2));
            }
            var result = list.ToArray();
            return Encoding.ASCII.GetString(result);
        }

        public string TextToBinary(string text)
        {
            var bytes = Encoding.ASCII.GetBytes(text);
            return string.Join(" ", bytes.Select(byt => System.Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
    }
}