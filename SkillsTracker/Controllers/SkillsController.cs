using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Skills()
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
        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            //DATE
            //C#: learning Basic, Building Apps, Master Coder
            //JavaScript: learning Basic, Building Apps, Master Coder
            //Python: learning Basic, Building Apps, Master Coder
            //
            string html = @"
            <form method='post'>
            <label for='date'>Date: </label><br/>
            <input type='date' name='date'/><br/>

            <label for='Csharpskill'>C#: </label><br/>
            <select name='Csharpskill'>
                <option value=''>* Select Skill Base *</option>
                <option value='Learning Basics'>Learning Basics</option>
                <option value='Building Apps'>Building Apps</option>
                <option value='Master Coder'>Master Coder</option>
            </select><br/>
            <label for='jsskill'>JavaScript: </label><br/>
            <select name='jsskill'>
                <option value=''>* Select Skill Base *</option>
                <option value='Learning Basics'>Learning Basics</option>
                <option value='Building Apps'>Building Apps</option>
                <option value='Master Coder'>Master Coder</option>
            </select><br/>
            <label for='pythonskill'>Python: </label><br/>
            <select name='pythonskill'>
                <option value=''>* Select Skill Base *</option>
                <option value='Learning Basics'>Learning Basics</option>
                <option value='Building Apps'>Building Apps</option>
                <option value='Master Coder'>Master Coder</option>
            </select><br/>
            <input type='submit' value='Submit'/>
            </form>
            ";
            return Content(html, "text/html");
        }

        [HttpPost("/skills/form")]
        public IActionResult Retrieves(string date, string Csharpskill, string jsskill, string pythonskill)
        {
            string html = "<h1>" + date + "</h1>" +
            "<ol>" +
                "<li>" + "C#: " + Csharpskill + "</li>" +
                "<li>" + "JavaScript: " + jsskill + "</li>" +
                "<li>" + "Python: " + pythonskill + "</li>" +
            "</ol>";

            return Content(html, "text/html");
        }
    }
}
