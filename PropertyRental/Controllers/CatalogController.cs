using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PropertyRental.Models;


namespace PropertyRental.Controllers
{

    namespace PropertyRental.Controllers
    {

        public class CatalogController : Controller
        {

            public IActionResult Test()
            {
                return View();
            }

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]

            public IActionResult RegisterProperty([FromBody] Property p)
            {
                Console.WriteLine("User is saving Property info");

                return Json(p);
            }
        }
    }
}

