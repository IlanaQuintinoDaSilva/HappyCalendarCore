using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HappyCalendarCore.Controllers
{
    public class CategoryController : Controller
    {
        // GET: /Category/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryDetails(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
