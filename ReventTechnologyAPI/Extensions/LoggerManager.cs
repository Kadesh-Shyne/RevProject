using Microsoft.Extensions.Logging;

namespace ReventTechnologyAPI.Extensions
{
    public class LoggerManager : ILoggerManager
    {
        private readonly ILogger<LoggerManager> logger;

        public LoggerManager(ILogger<LoggerManager> logger)
        {
            this.logger = logger;
        }

        public void LogDebug(string message) => logger.LogDebug(message);

        public void LogError(string message) => logger.LogError(message);

        public void LogInfo(string message) => logger.LogInformation(message);

        public void LogWarn(string message) => logger.LogWarning(message);
    }
}
