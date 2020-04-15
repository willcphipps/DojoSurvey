using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers {
    public class HomeController : Controller {
        [HttpGet ("")]
        public IActionResult Index () {
            return View ("Index");
        }

        [HttpPost ("result")]
        public IActionResult Result (Survey results) {
            if (ModelState.IsValid){
                return View("Success", results);
            }
            else{
                return View("Index");
            }
        }


    }
}