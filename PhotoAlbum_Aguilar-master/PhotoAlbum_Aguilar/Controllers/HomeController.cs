using Microsoft.AspNetCore.Mvc;
using PhotoAlbum_Aguilar.Models;
using System.Diagnostics;

namespace PhotoAlbum_Aguilar.Controllers
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
        
        public IActionResult ford()
        {
            return View();
        }
        public IActionResult mazda()
        {
            return View();
        }
        public IActionResult mercedes()
        {
            return View();
        }
        public IActionResult mitsu()
        {
            return View();
        }
        public IActionResult toyota()
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
