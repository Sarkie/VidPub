using System;
using NLog;

namespace VidPub.Web.Infrastructure.Logging
{
    public class NLogger : ILogger
    {
        private readonly Logger logger;

        public NLogger()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(Exception exception)
        {
            logger.Error(exception);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogFatal(Exception exception)
        {
            logger.Fatal(exception);
        }

        public void LogFatal(string message)
        {
            logger.Fatal(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarning(string message)
        {
            logger.Warn(message);
        }
    }
}