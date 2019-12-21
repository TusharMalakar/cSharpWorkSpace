using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// user will log-in and sign-up using this controller
namespace core_services_cSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // GET: api/Auth
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Welcome to cSharp Web API" };
        }

        

        // POST: api/Auth
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
