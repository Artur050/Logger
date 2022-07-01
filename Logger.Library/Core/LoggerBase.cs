namespace Logger.Library.Core
{
    /// <summary>
    /// Базовый класс логирования
    /// </summary>
    public abstract class LoggerBase : ILogger
    {
        /// <summary>
        /// Метод для обычных сообщений, информирующий о действиях системы
        /// </summary>
        /// <param name="message"></param>
        public void LogInfo(string message)
        {
            Log(LogType.INFO, message);
        }

        /// <summary>
        /// Метод для сообщений, когда система пытается привлечь внимание обслуживающего персонала
        /// </summary>
        /// <param name="message"></param>
        public void LogWarn(string message)
        {
            Log(LogType.WARN, message);
        }

        /// <summary>
        /// Метод сообщения отладки, профилирования.
        /// </summary>
        /// <param name="message"></param>
        public void LogDebug(string message)
        {
            Log(LogType.DEBUG, message);
        }

        /// <summary>
        /// Метод для сообщений, указывающих на ошибки в работе системы, требующих вмешательства
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            Log(LogType.ERROR, message);
        }

        /// <summary>
        /// Метод принимающий тип сообщения и текст сообщения
        /// </summary>
        /// <param name="type">Принимает тип сообщения</param>
        /// <param name="message">Содержание сообщения</param>
        public abstract void Log(LogType type, string message);
    }
}
