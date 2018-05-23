using System.Globalization;
using NLog;

namespace Kistler.Example.NLogService.Logging
{
   internal class LogEventInfoProvider
    {
       internal LoggingMessageParameters Parameters { get; set; }
        public string Source { get; protected set; }

        internal LogEventInfoProvider(LoggingMessageParameters parameters)
       {
           Parameters = parameters;
       }


        internal LogEventInfo GetLogEventInfo()
       {
           return LogEventInfo.Create(Parameters.Level, Parameters.LoggerName, Parameters.Exception, CultureInfo.InvariantCulture, Parameters.Message);
        }
    }
}
