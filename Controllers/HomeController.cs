using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers {
    public class HomeController : Controller {
        public static Dictionary<string, string> Results = new Dictionary<string, string> ();
        [HttpGet ("")]
        public IActionResult Index () {
            return View ("Index");
        }

        [HttpPost ("result")]
        public IActionResult Result (Survey result) {
            Survey FormData = result;
            return View (FormData);
        }

    }
}