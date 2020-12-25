using System;

namespace SingletonWork
{
    public abstract class BaseLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            WriteMessage(message, MessageType.Info);
        }
        public void LogWarning(string message)
        {
            WriteMessage(message, MessageType.Warning);
        }

        public void LogError(string message)
        {
            WriteMessage(message, MessageType.Error);
        }
        public abstract void WriteMessage(string message, MessageType type);

        protected virtual string FormatMessage(string message, MessageType type)
        {
            return $"{DateTimeOffset.Now:yyyy-MM-ddTHH:mm:ss+0000}\t{type}:\t{message}";
        }
    }
}
