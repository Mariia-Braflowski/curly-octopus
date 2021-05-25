using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Controllers
{
    public class HelloWorldController : Controller
    {
        [Route("Index")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            return View();
        }
        [Route("Test")]
        [HttpGet]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
