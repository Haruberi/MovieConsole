using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Http;

using Movie_Console.MovieAPI;
using Movie_Console.Menu;

using RestSharp;
using RestSharp.Deserializers;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Movie_Console.Interface
{
    public interface IMovieService
    {
        Task<List<Movie>> GetMoviesAsync();
        Task<Response> GetMovieAsync(string id);
    }
    public class MovieService : IMovieService
    {
        //GET - GetMoviesAsync
        public async Task<List<Movie>> GetMoviesAsync()
        {
            var client = new RestClient($"https://localhost:5001/api/Movie");
            var getRequest = new RestRequest(Method.GET);
            var cancellationTokenSource = new CancellationTokenSource();

            var response2 = client.Execute<List<Movie>>(getRequest);

            var deserializedResponse = JsonConvert.DeserializeObject<List<Movie>>(response2.Content,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

            return deserializedResponse;
        }



        //GET ID - GetMovieAsync
        public async Task<Response> GetMovieAsync(string id)
        {
            Response response = null;

            var getIdMovie = new RestClient($"https://localhost:5001/api/Movie/{id}");
            var getIdRequest = new RestRequest(Method.GET);

            try
            {
                var getResponse = await getIdMovie.GetAsync<Response>(getIdRequest);
                response = getResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine("Get movie by specific ID failed", e.Message);
            }
            finally
            {
                Console.WriteLine("GET movie success!");
            }

            return response;
        }
    }
}
        

    





