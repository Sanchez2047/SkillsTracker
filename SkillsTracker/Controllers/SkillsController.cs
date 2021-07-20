using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpPost]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html = @"
            <h1>Skills Tracker</h1>
            <h2>Coding skills to learn</h2>
            <ol>
                <li>C#</li>
                <li>JavaScript</li>
                <li>Python</li>
            </ol>
            ";

            return Content(html, "text/html");
        }
    }
}
