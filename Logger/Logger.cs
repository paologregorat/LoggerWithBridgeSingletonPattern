using BridgePatternExample.Abstract;
using BridgePatternExample.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePatternExample.Logger
{
    public class Logger
    {
        readonly string _fileLog = @"C:\prova.txt";
        public enum OutputTypes
        {
            Console,
            File
        }

        private OutputTypes _outputType;
        private Logger() { }

        
        private static Logger _instance;

        public static Logger GetInstance(OutputTypes outputType)
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            _instance._outputType = outputType;
            return _instance;
        }

        public void LogError(string msg, OutputTypes? outputType = default)
        {
            outputType = outputType !=default ? outputType : _outputType;
            switch (outputType)
            {
                case OutputTypes.Console:
                    {
                        AbstractLogger logger = null;
                        LogError errLog = new LogError();
                        logger = new ConsoleLogger();

                        errLog.SetLogger(logger);

                        errLog.Log(msg);
                        break;
                    }
                case OutputTypes.File:
                    {
                        AbstractLogger logger = null;
                        LogError errLog = new LogError();
                        logger = new FileLogger(_fileLog);

                        errLog.SetLogger(logger);

                        errLog.Log(msg);
                        break;
                    }
            }
        }

        public void LogInfo(string msg, OutputTypes? outputType = default)
        {
            outputType = outputType != default ? outputType : _outputType;
            switch (outputType)
            {
                case OutputTypes.Console:
                    {
                        AbstractLogger logger = null;
                        LogInfo lLog = new LogInfo();
                        logger = new ConsoleLogger();

                        lLog.SetLogger(logger);

                        lLog.Log(msg);
                        break;
                    }
                case OutputTypes.File:
                    {
                        AbstractLogger logger = null;
                        LogInfo lLog = new LogInfo();
                        logger = new FileLogger(_fileLog);

                        lLog.SetLogger(logger);

                        lLog.Log(msg);
                        break;
                    }
            }
        }

        public void LogWorning(string msg, OutputTypes? outputType = default)
        {
            outputType = outputType != default ? outputType : _outputType;
            switch (outputType)
            {
                case OutputTypes.Console:
                    {
                        AbstractLogger logger = null;
                        LogWarning lLog = new LogWarning();
                        logger = new ConsoleLogger();

                        lLog.SetLogger(logger);

                        lLog.Log(msg);
                        break;
                    }
                case OutputTypes.File:
                    {
                        AbstractLogger logger = null;
                        LogWarning lLog = new LogWarning();
                        logger = new FileLogger(_fileLog);

                        lLog.SetLogger(logger);

                        lLog.Log(msg);
                        break;
                    }
            }
        }
    }
}
