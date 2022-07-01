using Logger.Library.Core;
using System;

namespace Logger.Library.Loggers
{
    /// <summary>
    /// Логгирование в консоль
    /// </summary>
    public class ConsoleLogger : LoggerBase
    {
        /// <summary>
        /// Запись логов в консоль
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
       public override void Log(LogType type, string message)
        {
            Console.WriteLine($"{DateTime.Now} {type}: {message}");
        }
    }
}