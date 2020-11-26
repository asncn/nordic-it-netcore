using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_13
{
    class MultipleLogWriter : BaseLogWriter
    {
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
