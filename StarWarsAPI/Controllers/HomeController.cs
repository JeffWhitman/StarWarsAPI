using Microsoft.AspNetCore.Mvc;
using StarWarsAPI.Models;
using StarWarsAPI.Services;
using System.Diagnostics;

namespace StarWarsAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            StarWarsData starWarsData = new StarWarsData();
            RequestData requestData = new RequestData { URL= "https://swapi.dev/api/" };

            var response = await starWarsData.GetStarWarsInformation(requestData);
            
            return View(response);
        }
        public async Task<IActionResult> Film(ResponseData model, string url)
        {
            StarWarsData starWarsData = new StarWarsData();

            RequestData requestData = new RequestData { URL = url};

            var response = await starWarsData.GetStarWarsInformation(requestData);

            return View(response);

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