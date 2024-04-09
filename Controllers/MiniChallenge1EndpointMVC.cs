using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace endPoint1MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MiniChallenge1EndpointMVC : ControllerBase
    {
        [HttpGet]
        public string hello(string name){
            return "hello " + name;
        }

    }
}