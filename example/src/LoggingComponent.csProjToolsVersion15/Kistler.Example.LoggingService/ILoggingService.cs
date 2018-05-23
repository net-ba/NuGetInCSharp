using System;

namespace Kistler.Example.LoggingService
{
    /// <summary>
    /// Interface for logging NLog service
    /// </summary>
    public interface ILoggingService
    {
        /// <summary>
        /// Debugs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="data">The data.</param>
        void Debug(string message, params object[] data);
        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="data">The data.</param>
        void Error(string message, Exception ex = null, params object[] data);
        /// <summary>
        /// Informations the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="data">The data.</param>
        void Info(string message, params object[] data);
        /// <summary>
        /// Warns the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="data">The data.</param>
        void Warn(string message, Exception ex = null, params object[] data);
        /// <summary>
        /// Fatals the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="data">The data.</param>
        void Fatal(string message, Exception ex, params object[] data);
        /// <summary>
        /// Traces the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="data">The data.</param>
        void Trace(string message, params object[] data);

        /// <summary>
        /// Logs the specified log type.
        /// </summary>
        /// <param name="logType">Type of the log.</param>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="data">The data.</param>
        void Log(LoggingLevel logType, string message, Exception ex = null, params object[] data);

    }
}