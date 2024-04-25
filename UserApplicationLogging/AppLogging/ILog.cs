using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogging
{
    public interface ILog
    {
        void Log(LogModel log);
    }
}
