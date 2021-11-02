using IntegrationPoC.Contracts;
using IntegrationPoC.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IntegrationPoC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FestivalsController : ControllerBase
    {
        private IFestivalService _festivalService;
        private readonly ILogger<FestivalsController> _logger;

        public FestivalsController(ILogger<FestivalsController> logger, IFestivalService festivalService)
        {
            _logger = logger;
            _festivalService = festivalService;
        }

        [HttpGet]
        public IEnumerable<recordLabel> Get()
        {

            return _festivalService.GetFestival();

        }
    }
}
