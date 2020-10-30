using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Family.Web.Models;

namespace Family.Web.Controllers
{
    public class FamilyController : Controller
    {
        private readonly ILogger<FamilyController> _logger;

        public FamilyController(ILogger<FamilyController> logger)
        {
            _logger = logger;
        }

        public IActionResult FamilyManager()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
