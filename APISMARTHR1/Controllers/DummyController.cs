using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISMARTHR1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APISMARTHR1.Controllers
{
    [ApiController]
    public class DummyController : ControllerBase
    {
        private EmployerContext _employerContext;

        public DummyController(EmployerContext employerContext)
        {
            _employerContext = employerContext;
        }

        [HttpGet]
        [Route("api/testDatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }

    }
}