using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using powerbill.Models;

namespace powerbill.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ans = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(bill model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ans = model.main();
            }
            else
            {
                ViewBag.ans = 0;
            }
            return View(model);
        }
    }
}
