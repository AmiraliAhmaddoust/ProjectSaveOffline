using Microsoft.AspNetCore.Mvc;
using offlineSave.Models;
using System.Diagnostics;

namespace offlineSave.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        public IActionResult checkstatus()
        {
            return Json(true);
        }
        [HttpGet]
        public IActionResult save()
        {
            return View();
        }
        [HttpPost]
        public IActionResult save(List<ObjectDto> data)
        {
           
            var t= data.ToList();
            var a = 0;
            return Json(a);
        }
    }
}