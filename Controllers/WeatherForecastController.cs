using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BridgePatternExample.Abstract;
using BridgePatternExample.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static BridgePatternExample.Logger.Logger;

namespace BridgePatternExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private OutputTypes _outputType;

        public WeatherForecastController()
        {
        }

        [HttpGet]
        public void Get()
        {
            _outputType = OutputTypes.Console;
            var logger = GetInstance(_outputType);
            //AbstractLogger logger = null;

            //LogError err = new LogError();
            //logger = new ConsoleLogger();

            //err.SetLogger(logger);

            //err.Log("Ciao");
            logger.LogError("Questo è un errore scritto su console");

            logger.LogInfo("Questa è una informazione scritto su console");

            logger.LogWorning("Questo è un warning scritto su file", OutputTypes.File);
        }

        

    }
}
