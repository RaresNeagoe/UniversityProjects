using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogging
{
    public class LogModel
    {
        public string Message { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"[{DateTime.Now}: [{((LogLevel)Level).ToString()}]] - {Message};";
        }
    }
}
