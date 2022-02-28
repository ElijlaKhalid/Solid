using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.reqclass
{
    public sealed class Logger
    {
        private Logger()
        { }

        private static Logger logger;

        public static Logger GetLogger()
        {
            return logger ??= new Logger();
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}