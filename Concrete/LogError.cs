using BridgePatternExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePatternExample.Concrete
{
    public class LogError : ILogEvent
    {
        protected AbstractLogger _logEvent;

        public LogError()
        {
            
        }

        public void  SetLogger(AbstractLogger logger)
        {
            _logEvent = logger;
        }

        public virtual void Log(string msg)
        {
            _logEvent.LogError(msg);
        }
    }
}
