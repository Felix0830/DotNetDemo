using System;
using Microsoft.Extensions.Logging;

namespace CSharpConsoleDemo
{
    public class LogHelper
    {
        //private readonly ILogger _logger;
        private readonly ILogger<LogHelper> _logger;

        public LogHelper(ILogger<LogHelper> logger)
        {
            // _logger = LoggerFactory.Create(builder => { builder.AddConsole().SetMinimumLevel(LogLevel.Debug); }).CreateLogger("MyLogHelper");
            _logger = logger; 

        }

        public void LogInfo(string message)
        {
            _logger.LogInformation($"loginformation -> {message} {DateTime.Now}");
        }

        public void LogDebug(string message)
        {
            _logger.LogDebug($"logdebug -> {message} {DateTime.Now}");
        }
    }
}
