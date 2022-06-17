using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase
    {
        public CalcController()
        {
        }

        [HttpGet("{n1}/{n2}")]
        public ActionResult Get(int n1,int n2)
        {
            return Ok(n1+n2);
        }
    }
}
