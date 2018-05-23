using System;
using Kistler.Example.LoggingService;
using LogLevel = NLog.LogLevel;

namespace Kistler.Example.NLogService.Logging
{
   internal static class Helpers
    {
       internal static LogLevel ToLogLevel(this LoggingLevel logType)
       {
           switch (logType)
           {
               case LoggingLevel.Trace:
                   return LogLevel.Trace;
               case LoggingLevel.Debug:
                   return LogLevel.Debug;
               case LoggingLevel.Info:
                   return LogLevel.Info;
               case LoggingLevel.Warn:
                   return LogLevel.Warn;
               case LoggingLevel.Error:
                   return LogLevel.Error;
               case LoggingLevel.Fatal:
                   return LogLevel.Fatal;
               default:
                   throw new ArgumentOutOfRangeException(nameof(logType), logType, null);
           }
       }
    }
}
