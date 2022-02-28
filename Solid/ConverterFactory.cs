using Solid.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public static class ConverterFactory
    {
        public static Converter Create(BaseType baseType, int decimalNumber)
        {
            try
            {
                return (Converter)Activator.CreateInstance(
                Type.GetType($"Solid.Converters.{baseType}Converter"),
                new object[] { decimalNumber });
            }
            catch (Exception ex)
            {
                return new InvalidBaseConverter(0);
            }

            //if (baseType == BaseType.Binary)
            //{
            //    return new BinaryConverter(decimalNumber);
            //}
            //if (baseType == BaseType.Octal)
            //{
            //    return new OctalConverter(decimalNumber);
            //}
            //if (baseType == BaseType.Hexadecimal)
            //{
            //    return new HexadecimalConverter(decimalNumber);
            //}
            //else
            //{
            //    return null;
            //}
        }
    }
}