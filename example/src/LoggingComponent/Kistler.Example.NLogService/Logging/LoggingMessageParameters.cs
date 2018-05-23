using System;
using NLog;

namespace Kistler.Example.NLogService.Logging
{
   internal class LoggingMessageParameters
    {
       internal LogLevel Level { get;  set; }
       internal string Message { get;  set; }
       internal Exception Exception { get;  set; }
       internal string LoggerName { get;  set; }
       internal object[] Data { get; set; }

    
    }
}
