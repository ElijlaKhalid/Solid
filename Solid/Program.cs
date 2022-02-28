using Solid.reqclass;
using System;

namespace Solid
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Logger ConsoleLogger = new();
            NumberConverter numberConverter = new NumberConverter(logger: ConsoleLogger, reader: new Reader(ConsoleLogger), writer: new TextFileLogger());
            numberConverter.Convert();
        }
    }
}