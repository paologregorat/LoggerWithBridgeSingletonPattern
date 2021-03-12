using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePatternExample.Abstract
{
    public abstract class AbstractLogger
    {
        public abstract void LogError(string msg);
        public abstract void LogInfo(string msg);
        public abstract void LogWarning(string msg);
    }
}
