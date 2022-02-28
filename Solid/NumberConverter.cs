using Solid.Converters;
using Solid.reqclass;

namespace Solid
{
    public enum BaseType
    {
        Binary = 2,
        Octal = 8,
        Hexadecimal = 16,
        None = 0
    }

    internal class NumberConverter
    {
        public int DecimalNumber { get; set; }

        public void Convert()
        {
            Logger.GetLogger().Log("Program is starting...");
            Logger.GetLogger().Log("Enter the number to convert:");
            DecimalNumber = Reader.ReadInteger();
            Logger.GetLogger().Log("Enter the base type (Ex: 2,8,16):");

            var baseType = (BaseType)Reader.ReadInteger();
            string result;
            var type = ConverterFactory.Create(baseType, DecimalNumber);

            result = type.Convert();
            Logger.GetLogger().Log(result);
            Logger.GetLogger().Log("Program is ending..");
        }
    }
}