using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers {
    public class HomeController : Controller {
        public static Dictionary<string, string> Results = new Dictionary<string, string> ();
        [HttpGet ("")]
        public IActionResult Index () {
            return View ("Index");
        }

        [HttpPost ("result")]
        public IActionResult Result (string name, string location, string language, string message) {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.message = message;

            return View ("Result");
        }

    }
}