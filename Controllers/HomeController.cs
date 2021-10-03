using System;
using Microsoft.AspNetCore.Mvc;
using Boilerplate.Models;

namespace Boilerplate.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {
            return View();
        }

    }
}
