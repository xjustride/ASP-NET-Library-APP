using Labolatorium_3_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Labolatorium_3_App.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult bibl1()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index1() 
        {
            return View();
        }
    }
}
