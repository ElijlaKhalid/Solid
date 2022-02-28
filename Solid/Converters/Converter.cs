using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Converters
{
    public abstract class Converter
    {
        public int DecimalNumber { get; set; }

        public Converter(int decimalNumber)
        {
            DecimalNumber = decimalNumber;
        }

        public abstract string Convert();
    }
}