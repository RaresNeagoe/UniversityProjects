using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogging.Internal
{
        internal class ConsoleLogging : ILog
        {
            public void Log(LogModel log)
            {
                Console.WriteLine(log);
            }
        }
}
