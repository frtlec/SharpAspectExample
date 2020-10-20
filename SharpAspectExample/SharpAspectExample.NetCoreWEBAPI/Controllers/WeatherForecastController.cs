using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SharpAspectExample.Business.Abstract;

namespace SharpAspectExample.NetCoreWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
      

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IService _service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public string Get()
        {
            return _service.Test();
        }
    }
}
