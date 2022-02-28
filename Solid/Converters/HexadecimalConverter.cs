using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Converters
{
    public class HexadecimalConverter : Converter
    {
        public HexadecimalConverter(int decimalNumber) : base(decimalNumber)
        {
        }

        public override string Convert()
        {
            return $"The result is: {System.Convert.ToString(DecimalNumber, 16)}";
        }
    }
}