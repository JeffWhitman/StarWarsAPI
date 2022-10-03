using Microsoft.Extensions.Configuration;
using StarWarsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsAPI.Services
{
    public class StarWarsData
    {

        public async Task<ResponseData> GetStarWarsInformation(RequestData requestData)
        {
            using (HttpClient client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get, requestData.URL);

                HttpResponseMessage responseStarWarsData = client.SendAsync(request).Result;

                if (responseStarWarsData.IsSuccessStatusCode)
                {
                    var result = await responseStarWarsData.Content.ReadFromJsonAsync<ResponseData>();

                    return result;
                }
                else
                {
                    return new ResponseData { ErrorMessage = responseStarWarsData.ReasonPhrase };

                }
            }
        }

        public async Task<FilmResponseData> GetStarWarsFilmInformation(RequestData requestData)
        {
            using (HttpClient client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get, requestData.URL);

                HttpResponseMessage responseStarWarsData = client.SendAsync(request).Result;

                if (responseStarWarsData.IsSuccessStatusCode)
                {
                    var result = await responseStarWarsData.Content.ReadFromJsonAsync<FilmResponseData>();

                    return result;
                }
                else
                {
                    return new FilmResponseData { ErrorMessage = responseStarWarsData.ReasonPhrase };

                }
            }
        }

        public async Task<CharactersResponseData> GetStarWarsCharactersInformation(RequestData requestData)
        {
            using (HttpClient client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get, requestData.URL);

                HttpResponseMessage responseStarWarsData = client.SendAsync(request).Result;

                if (responseStarWarsData.IsSuccessStatusCode)
                {
                    var result = await responseStarWarsData.Content.ReadFromJsonAsync<CharactersResponseData>();

                    return result;
                }
                else
                {
                    return new CharactersResponseData { ErrorMessage = responseStarWarsData.ReasonPhrase };

                }
            }
        }

    }
}
