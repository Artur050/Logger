using Logger.Library.Core;
using Logger.Library.Loggers;

void RunLogger(ILogger logger)
{
    logger.LogInfo("Сообщение об ошибке");
    logger.LogWarn("Быстрее чинить");
    logger.LogDebug("Не успеваешь, быстрей");
    logger.LogError("Ну всё, не успел...");
};

RunLogger(new ConsoleLogger());
RunLogger(new FileLogger("log.txt"));