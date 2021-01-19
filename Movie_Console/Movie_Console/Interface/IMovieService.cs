using Movie_Console.MovieAPI;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Movie_Console.Interface
{
    public interface IMovieService
    {
        Movie CreateMovie(Movie movie);
        List<Movie> GetMovies();
        Task<Movie> GetMovieAsync(string id);
        Task<Movie> CreateMovieAsync(Movie movie);
        Task<Movie> DeleteMovieAsync(string id);
        Task RunAsync();

    }
    public class MovieService
    {
        public Movie CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> _movies = new List<Movie>()
        {
            new Movie { Id = "Movie_1", MovieTitle = "The big pineapple", ReleaseYear = 2020 },
            new Movie { Id = "Movie_2", MovieTitle = "The medium mango", ReleaseYear = 2021 },
            new Movie { Id = "Movie_3", MovieTitle = "The small apple", ReleaseYear = 20219 },

        };
        public List<Movie> GetMovies()
        {
            return _movies;
        }

        //RUNASYNC
        public static async Task RunAsync()
        {
            var runMovie = await new MovieService().GetMovieAsync("Movie_1");
            var menuChoice = RunMenu();
            switch (menuChoice)
            {
                /*case "Open menu":
                    var openMenu = await MovieService.RunAsync();
                    Console.WriteLine("");
                        break;
                case "GetMovie":
                    var getMovie = await MovieService.GetMovieAsync(Id);
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                case "CreateMovie":
                    var postClient = await new MovieService().CreateMovieAsync("");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                case "DeleteMovie":
                    var deleteClient = await new MovieService().DeleteMovieAsync("");
                    Console.WriteLine();
                    Console.ReadLine();
                default:
                    Console.WriteLine("Please enter correct number to continue.");
                    break;*/
            }
        }

        private static object RunMenu()
        {
            throw new NotImplementedException();
        }

        //GET
        public async Task<Movie> GetMovieAsync(string id)
        {
            Movie movie = null;
            //Anrop till ditt API
            //GET
            var getMovie = new RestClient($"https://localhost:5001/api/Movie/{id}");
            //getMovie.Authenticator = new HttpBasicAuthenticator("id", "movieTitle");
            var getRequest = new RestRequest(Method.GET);
            movie = await getMovie.GetAsync<Movie>(getRequest);
            return movie;
        }

        //POST
        public async Task<Movie> CreateMovieAsync(Movie movie)
        {
            //1. Create a request pointing to service endpoint
            var postClient = new RestClient($"https://localhost:5001/api/Movie");

            //2. Create a JSON request which contains all the fields
            JObject jObjectbody = new JObject();
            jObjectbody.Add("Id", "Movie_1");
            jObjectbody.Add("MovieTitle", "The big pineapple");
            jObjectbody.Add("ReleaseYear", 2021);
            try
            {
                //3. Add JSON body in the request and send the request
                var postRequest = new RestRequest("new_movie.json", DataFormat.Json);
                //4. Validate the response
                var postResponse = await postClient.GetAsync<Movie>(postRequest, CancellationToken.None);
            }
            catch (Exception e)
            {
                //IRestClient.ThrowOnAnyError = true;
            }
            finally
            {
                Console.WriteLine("POST method created");
            }
            return movie;
               


            //DELETE
            /*public async Task<Movie> DeleteMovieAsync(string id)
            {
                var deleteClient = new RestClient($"https://localhost:5001/api/Movie/{id}");
                var deleteRequest = new RestRequest("movie/{id}", Method.DELETE) { RequestFormat = DataFormat.Json };
                try
                {
                    deleteRequest.AddParameter("application/json", id, ParameterType.RequestBody);
                    var deleteResponse = await deleteClient.ExecuteAsync(deleteRequest, CancellationToken.None);
                }
                catch (Exception)
                {
                    //Add exception
                    return movie;
                }
                finally
                {
                    Console.WriteLine("DELETE method created");
                }*/
            
            }
        }
    }


//behövs View här?





