using BridgePatternExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePatternExample.Concrete
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger()
        {
        }
        public override void LogError(string msg)
        {
            Console.WriteLine("Error " + msg);
        }

        public override void LogInfo(string msg)
        {
            Console.WriteLine("Info " + msg);
        }

        public override void LogWarning(string msg)
        {
            Console.WriteLine("Warning " + msg);
        }
    }
}
