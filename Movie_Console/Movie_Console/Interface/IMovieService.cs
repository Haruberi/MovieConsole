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
        Task<Movie> GetMovieAsync(string id);
        Task<Movie> CreateMovieAsync(Movie movie);
        Task<Movie> DeleteMovieAsync(string id);
        Task RunAsync();

    }
    public class MovieService : IMovieService
    {
        public async Task RunAsync()
        {

            var key = Console.ReadLine();
            switch (key)
            {
                //GET
                case "1":
                    Console.WriteLine("- - - - - GET MOVIE - - - - -");
                    Console.WriteLine("- - - - - - - - - - - - - - -");
                    //var getMovie = await MovieService.GetMovieAsync(id);
                    break;

                //POST
                case "2":
                    Console.WriteLine("- - - - - CREATE NEW MOVIE - - - - -");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                    //var postClient = await new MovieService().CreateMovieAsync(movie);
                    break;

                //DELETE
                case "3":
                    Console.WriteLine("- - - - - DELETE MOVIE - - - - -");
                    Console.WriteLine("- - - - - - - - - - - - - - - - -");
                    //var deleteClient = await new MovieService().DeleteMovieAsync(id);
                    //Console.WriteLine("- - - - - - - - - - - - - - ENTER ID TO DELETE MOVIE - - - - - - - - - - ");
                    //Console.ReadLine();
                    break;

                //DEFAULT
                default:
                    Console.WriteLine("Start over");
                    break;
            }
        }
        //GET - GetMoviesAsync
        public async Task<List<Movie>> GetMoviesAsync()
        {
            //Movie movie = null;
            var client = new RestClient($"https://localhost:5001/api/Movie");
            var getRequest = new RestRequest(Method.GET);
            var cancellationTokenSource = new CancellationTokenSource();

            //få in under kod här:

            //using (var client = new HttpClient())
            //{
            //    using (var response = await client.GetAsync(url))
            //    {
            //        var responseCont = response.Content;
            //        stringResp = await responseCont.ReadAsStringAsync();
            //    }
            //}

            var response2 = client.Execute<List<Movie>>(getRequest);
            //var data = response2.Data;
            //RestResponse<Movie> response = await getMovie.ExecuteAsync(getRequest);

            //RestResponse<List> response = await getMovie.Execute(getRequest);

            var deserializedResponse = JsonConvert.DeserializeObject<List<Movie>>(response2.Content,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

            //return Ok(deserializedResponse);

            return deserializedResponse;
        }
        
        

        //GET ID - GetMovieAsync
        public async Task<Movie> GetMovieAsync(string id)
        {
            Movie movie = null;

            var getIdMovie = new RestClient($"https://localhost:5001/api/Movie/{id}");
            var getIdRequest = new RestRequest("Get movie from ID", Method.GET);

            try
            {
                var getResponse = await getIdMovie.GetAsync<Movie>(getIdRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine("Get movie by specific ID failed", e.Message);
            }
            finally
            {
                Console.WriteLine("GET movie success!");
            }

            return movie;
        }

        //POST
        public async Task<Movie> CreateMovieAsync(Movie movie)
        {

            var postClient = new RestClient($"https://localhost:5001/api/Movie");

            //var jObjectbody = new RestRequest("Create movie", Method.POST);

            //jObjectbody.AddParameter("Id", "Movie_1");
            //jObjectbody.AddParameter("MovieTitle", "The big pineapple");
            //jObjectbody.AddParameter("ReleaseYear", 2021);
            //jObjectbody.AddParameter("Description", "The story about the big pineapple");

            try
            {
                var postRequest = new RestRequest("new_movie.json", DataFormat.Json);
                var postResponse = await postClient.GetAsync<Movie>(postRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine("Create movie failed", e.Message);
            }
            finally
            {
                Console.WriteLine("POST movie success!");
            }
            return movie;
        }

        public Task<Movie> DeleteMovieAsync(string id)
        {
            throw new NotImplementedException();
        }


        //DELETE
        /*public async Task<Movie> DeleteMovieAsync(string id)
        {

        }
/*
            var deleteClient = new RestClient($"https://localhost:5001/api/Movie/{id}");

            //lägg till true false kod från api

            var deleteRequest = new RestRequest("Delete movie", Method.DELETE) { RequestFormat = DataFormat.Json };
            
            try
            {
                deleteRequest.AddParameter("application/json", id, ParameterType.RequestBody);
                var deleteResponse = await deleteClient.ExecuteAsync(deleteRequest);
                movieDelete = deleteResponse;
            }

            catch (Exception e)
            {
                Console.WriteLine("Delete movie failed", e.Message);
            }
            finally
            {
                Console.WriteLine("DELETE movie success!");
            }
            
            return Movie;*/
    }
    }


    





