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
        public ILogger Logger { get; set; }
        public IReader Reader { get; set; }
        public ILogger Writer { get; set; }

        public NumberConverter(ILogger logger, IReader reader, ILogger writer)
        {
            Logger = logger;
            Reader = reader;
            Writer = writer;
        }

        public void Convert()
        {
            Logger.Log("Program is starting...");
            Logger.Log("Enter the number to convert:");
            DecimalNumber = Reader.ReadInteger();
            Logger.Log("Enter the base type (Ex: 2,8,16):");
            var baseType = (BaseType)Reader.ReadInteger();
            Writer.Log($"Number to be Converted {DecimalNumber} with base type {baseType}");
            string result;
            var type = ConverterFactory.Create(baseType, DecimalNumber);
            result = type.Convert();
            Logger.Log(result);
            Writer.Log(result);
            Logger.Log("Program is ending..");
        }
    }
}