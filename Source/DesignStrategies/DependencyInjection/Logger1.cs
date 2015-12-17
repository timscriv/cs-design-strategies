using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Logger1 : ILogger
    {
        public void WriteToLog(string text)
        {
            Console.WriteLine("***********\n {0}\n***********", text);
        }
    }
}
