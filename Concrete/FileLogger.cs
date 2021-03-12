using BridgePatternExample.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePatternExample.Concrete
{
    public class FileLogger : AbstractLogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public override void LogError(string msg)
        {
            using (var sw = File.AppendText(_path))
            {
                sw.WriteLine("Error " + msg);
            }
        }

        public override void LogInfo(string msg)
        {
            using (var sw = File.AppendText(_path))
            {
                sw.WriteLine("Info " + msg);
            }
        }

        public override void LogWarning(string msg)
        {
            using (var sw = File.AppendText(_path))
            {
                sw.WriteLine("Warning " + msg);
            }
        }
    }
}
