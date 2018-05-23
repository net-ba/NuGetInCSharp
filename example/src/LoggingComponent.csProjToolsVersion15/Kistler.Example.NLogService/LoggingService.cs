using System;
using System.Collections.Generic;
using System.Linq;
using Kistler.Example.LoggingService;
using Kistler.Example.NLogService.Logging;
using NLog;

namespace Kistler.Example.NLogService
{
   public class LoggingService : ILoggingService
   {
       protected IList<ILogger> Loggers;

       public LoggingService()
       {
           Loggers = new List<ILogger>(new []{ LogManager.GetCurrentClassLogger() });
       }

        public LoggingService(params string[] logerNames)
        {
            if (logerNames == null || logerNames.Length == 0)
            {
                Loggers = new List<ILogger>(new[] {LogManager.GetCurrentClassLogger()});
            }
            else
            {
                Loggers = logerNames.Select(LogManager.GetLogger).Cast<ILogger>().ToList();
            }

        }

        public virtual void Error(string message, Exception ex = null, params object[] data)
       {
           Log(LoggingLevel.Error, message, ex, data);
        }

        public virtual void Warn(string message, Exception ex = null, params object[] data)
        {
            Log(LoggingLevel.Warn, message, ex, data);
        }

        public virtual void Info(string message, params object[] data)
        {
            Log(LoggingLevel.Info, message,null, data);
        }

        public virtual void Debug(string message, params object[] data)
        {
           Log(LoggingLevel.Debug, message, null, data);
        }

        public virtual void Fatal(string message, Exception ex, params object[] data)
        {
            Log(LoggingLevel.Fatal, message, ex, data);
        }

        public void Trace(string message, params object[] data)
        {
            Log(LoggingLevel.Trace, message, null, data);
        }

        public virtual void Log(LoggingLevel logType, string message, Exception ex = null, params object[] data)
        {
            var parameters = new LoggingMessageParameters { Level = logType.ToLogLevel(), Message = message, Exception = ex, Data = data};
            Log(parameters);
        }


       private void Log(LoggingMessageParameters parameters)
       {          
           foreach (var logger in Loggers)
           {
               var par = parameters;
               par.LoggerName = logger.Name;
               var logEvenInfoProvider = new LogEventInfoProvider(par);
               
               //TODO: Add json data serialization
               logger.Log(GetType(), logEvenInfoProvider.GetLogEventInfo());
           }
       }


     
    

       

      
   }
}
