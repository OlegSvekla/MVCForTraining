using Microsoft.AspNetCore.Mvc;
using MVCForTraining.Models;
using System.Diagnostics;

namespace MVCForTraining.Controllers
{
    
    public class HomeController : Controller
    {
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index() => "Index Page";




        
        public IActionResult Example()
        {
            return Content("Example site");
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