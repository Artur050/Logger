using Logger.Library.Core;
using System;
using System.IO;

namespace Logger.Library.Loggers
{
    /// <summary>
    /// Логгирование в файл
    /// </summary>
    public class FileLogger : LoggerBase
    {
        private string _file;

        public FileLogger(string logFile)
        {
            _file = logFile;
        }

        /// <summary>
        /// Запись логов в файл. 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public override void Log(LogType type, string message)
        {
            // Реализация не производительная
            using (var fileWriter = File.AppendText(_file))
            {
                fileWriter.WriteLine($"{DateTime.Now} {type}: {message}");
            }
        }  
    }
}
