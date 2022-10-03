using StarWarsAPI.Models;
using System.Collections.Generic;

namespace StarWarsAPI.Services
{
    public class RequestDataService
    {
        public List<FilmModel> ReturnFilmModelList(ResponseData responseData)
        {
            List <FilmModel> filmModels = new List<FilmModel>();

            foreach (var filmData in responseData.results)
            {
                FilmModel filmModel = new FilmModel { Title=filmData.title,OpeningCrawl=filmData.opening_crawl,EpisodeId=filmData.episode_id.ToString(),Director=filmData.director,ReleaseDate=filmData.release_date, Url=filmData.url};

                filmModels.Add(filmModel);
            }
            return filmModels;
        }
    }
}
