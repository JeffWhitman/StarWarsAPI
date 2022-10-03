using Microsoft.AspNetCore.Mvc;
using StarWarsAPI.Models;
using StarWarsAPI.Services;
using System.Security.Policy;

namespace StarWarsAPI.Controllers
{
    public class FilmController : Controller
    {
        public async Task<IActionResult> Index(ResponseData model, string url)
        {
            StarWarsData starWarsData = new StarWarsData();
            RequestData requestData = new RequestData { URL = url };
            RequestDataService requestDataService = new RequestDataService();

            var response = await starWarsData.GetStarWarsInformation(requestData);

            List <FilmModel> filmModels = requestDataService.ReturnFilmModelList(response);

            return View(filmModels);

        }
        public async Task<IActionResult> Details(ResponseData model, string url)
        {
            StarWarsData starWarsData = new StarWarsData();
            RequestData requestData = new RequestData { URL = url };
            RequestDataService requestDataService = new RequestDataService();

            var response = await starWarsData.GetStarWarsFilmInformation(requestData);


            FilmModel filmModel = new FilmModel { Title = response.title, Director = response.director, EpisodeId = response.episode_id.ToString(), ReleaseDate = response.release_date, OpeningCrawl = response.opening_crawl };

            foreach (var characterUrl in response.characters)
            {
                requestData.URL = characterUrl;
                var responseCharacter = await starWarsData.GetStarWarsCharactersInformation(requestData);
                filmModel.Characters.Add(responseCharacter.name);

            }
            return View(filmModel);

        }

    }
}
