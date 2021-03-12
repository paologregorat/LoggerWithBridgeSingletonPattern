using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePatternExample.Abstract
{
    public interface ILogEvent
    {
        public void Log(string msg);
        public void SetLogger(AbstractLogger logger);
    }
}
