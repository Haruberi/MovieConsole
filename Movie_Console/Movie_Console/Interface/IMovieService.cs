using Movie_Console.MovieAPI;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Console.Interface
{
    public interface IMovieService
    {
        Movie CreateMovie(Movie movie);
        List<Movie> GetMovies();
        Task<Movie> GetMovieAsync(string id);
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

        //Get //Flytta till MovieService
        //static async Task<Movie> GetMovieAsync(string path)
        //{
        //    Movie movie = null;
        //    HttpResponseMessage response = await movie.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        movie = await response.Content.ReadAsAsync<Movie>();
        //    }
        //    return movie;
        //}
        public async Task<Movie> GetMovieAsync(string id)
        {
            //Anrop till ditt API
            Movie movie = null;
            //GET
            var getMovie = new RestClient($"https://localhost:5001/api/Movie/{id}");
            getMovie.Authenticator = new HttpBasicAuthenticator("id", "movieTitle");

            var getRequest = new RestRequest(Method.GET);
            var timeline = await getMovie.GetAsync<Movie>(getRequest);

            return movie;
            /*//getMovie.Authenticator = new HttpBasicAuthenticator("id", "movieTitle");
            //getMovie.Timeout = -1; ???
            var getRequest =new RestRequest(Method.GET);
            IRestResponse getResponse = getMovie.Execute(getRequest);
            var timeline = await getMovie.GetAsync<Movie>(getRequest);
            Console.WriteLine(getResponse.Content);*/
        }


        //Post //Flytta till movieservice
        //static async Task<Uri> CreateMovieAsync(Movie movie)
        //{
        //    HttpResponseMessage response = await movie.PostAsJsonAsync(
        //        "api/movies", movie);
        //    response.EnsureSuccessStatusCode();

        //    return response.Headers.Location;
        //}

        //POST
        //var postMovie = new RestClient($"https://localhost:5001/api/Movie/");
        //var postRequest = new RestRequest(Method.POST);
        //IRestResponse postResponse = postMovie.Execute(postRequest);
        //postRequest.AddBody(new Movie
        //{
        //    Id = "",
        //    MovieTitle = "",
        //    ReleaseYear = 1
        //});
        //postMovie.Execute(postRequest);


        //Delete
        //static async Task<HttpStatusCode> DeleteMovieAsync(string id)//Flytta till movieService
        //{
        //    HttpResponseMessage response = await movie.DeleteAsync(
        //        $"api/movies{id}");
        //    return response.StatusCode;
        //}
        //static void Main()
        //{
        //    RunAsync().GetAwaiter().GetResult();
        //}
        //DELETE
        //var item=new Movie({Id});
        //var client = new RestClient($"https://localhost:5001/api/Movie/");
        //var deleteRequest = new RestRequest(Method.DELETE);
        //deleteRequest.AddParameter("Id", id);

        //client.Execute(deleteRequest);



    }
}





