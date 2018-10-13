using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace UserMs.Controllers
{
    public class GreetingController : Controller
    {
        [Route("greeting")]
        public async Task<IActionResult> Get()
        {
            var client = new HttpClient();
            var s = await client.GetStringAsync("http://userms/user");

            return Ok("Hello " + s);
        }
    }
}
