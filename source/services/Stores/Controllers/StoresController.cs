using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Stores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoresController : ControllerBase
    {
        private readonly ILogger<DefaultController> _logger;

        public StoresController(ILogger<DefaultController> logger)
        {
            _logger = logger;
        }



        /// Returns all stores available for the current user that asks for them.
        [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}
