using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"FileLogger: {message}");
        }
    }

    public abstract class LoggerDecorator : ILogger
    {
        protected ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public abstract void Log(string message);
    }

    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestampedMessage = $"{DateTime.Now}: {message}";
            _logger.Log(timestampedMessage);
        }
    }

    public class ErrorCategoryLogger : LoggerDecorator
    {
        private string _category;

        public ErrorCategoryLogger(ILogger logger, string category) : base(logger)
        {
            _category = category;
        }

        public override void Log(string message)
        {
            string categorizedMessage = $"[{_category}] {message}";
            _logger.Log(categorizedMessage);
        }
    }

}
