using Microsoft.AspNetCore.Mvc;
using MVCForTraining.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace MVCForTraining.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task Index()
        {
            string content = @"<form method='post' action='/Home/PersonData'>
                   <label>Name:</label><br />
                <input name='name' /><br />
                <label>Age:</label><br />
                <input type='number' name='age' /><br />
                <input type='submit' value='Send' />
            </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(content);
        }
        [HttpPost]
        public string PersonData()
        {
            string name = Request.Form["name"];
            string age = Request.Form["age"];
            return $"{name}: {age}";
        }


        public IActionResult Privacy()
        {
            return View();
        }
       

        public string Example()
        {
            string name = Request.Query["name"];
            string age = Request.Query["age"];
            return $"Name: {name}  Age: {age}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}