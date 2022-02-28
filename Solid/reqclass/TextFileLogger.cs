using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.reqclass
{
    public class TextFileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter writer = File.AppendText(@"C:\Users\HP\source\repos\Solid\Solid\reqclass\logging.txt"))
            {
                writer.WriteLine(message);
            }
        }
    }
}