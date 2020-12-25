using System.Collections.Generic;
namespace SingletonWork
{
    class MultipleLogWriter : BaseLogWriter
    {

        private static MultipleLogWriter instance;
        private MultipleLogWriter()
        { }
        public static MultipleLogWriter GetMLWInstance(params ILogWriter[] writers)
        {
            if (instance == null)
                instance = new MultipleLogWriter();
            return instance;
        } 

        private IEnumerable<ILogWriter> _logWriters;

        public MultipleLogWriter(params ILogWriter[] writers)
        {
            _logWriters = writers;
        }

        public override void WriteMessage(string message, MessageType type)
        {
            foreach (var kind in _logWriters)
            {
                switch (type)
                {
                    case MessageType.Info:
                        kind.LogInfo(message);
                        break;
                    case MessageType.Warning:
                        kind.LogWarning(message);
                        break;
                    case MessageType.Error:
                        kind.LogError(message);
                        break;
                }
            }
        }
    }
}
