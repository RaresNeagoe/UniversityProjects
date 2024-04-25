using AppLogging.Internal;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogging
{
    public class LogFactory
    {
        private static ILog _instance;

        public static ILog Instance
        {
            get
            {
                if (_instance == null)
                {
                    //get from app.config (if exists)
                    var logType = ConfigurationManager.AppSettings["logType"];

                    if (string.IsNullOrWhiteSpace(logType))
                    {
                        logType = "Console";
                    }

                    LogOuput output = (LogOuput)Enum.Parse(typeof(LogOuput), logType);

                    switch (output)
                    {
                        case LogOuput.Console:
                            _instance = new ConsoleLogging();
                            break;
                        case LogOuput.File:
                            _instance = new FileLogging();
                            break;
                        case LogOuput.Database:
                            _instance = new DatabaseLogging();
                            break;
                    }
                }

                return _instance;
            }
        }
    }
}
