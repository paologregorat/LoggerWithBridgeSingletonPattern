using BridgePatternExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePatternExample.Concrete
{
    public class LogInfo : ILogEvent
    {
        protected AbstractLogger _logEvent;

        public LogInfo()
        {
            
        }

        public void  SetLogger(AbstractLogger logger)
        {
            _logEvent = logger;
        }

        public virtual void Log(string msg)
        {
            _logEvent.LogInfo(msg);
        }
    }
}
