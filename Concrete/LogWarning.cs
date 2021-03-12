using BridgePatternExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePatternExample.Concrete
{
    public class LogWarning : ILogEvent
    {
        protected AbstractLogger _logEvent;

        public LogWarning()
        {
            
        }

        public void  SetLogger(AbstractLogger logger)
        {
            _logEvent = logger;
        }

        public virtual void Log(string msg)
        {
            _logEvent.LogWarning(msg);
        }
    }
}
