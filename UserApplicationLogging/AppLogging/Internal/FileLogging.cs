using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppLogging.Internal
{
    public class FileLogging : ILog
    {
        private string FilePath;

        public FileLogging()
        {
            var filePath = ConfigurationManager.AppSettings["LogFileDirectory"];

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = "AppLogs";
            }

            if (!System.IO.Directory.Exists(filePath))
            {
                System.IO.Directory.CreateDirectory(filePath);
            }

            FilePath = Path.Combine(filePath, "Log.txt");
        }

        public void Log(LogModel log)
        {
            File.AppendAllText(FilePath, log.ToString() + "\n");
        }
    }
}
