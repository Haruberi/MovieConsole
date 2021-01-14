using Movie_Console.MovieAPI;
using RestSharp;
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
        Movie GetMovieAsync(string id);
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
        public Movie GetAsyncMovie(string id)
        {
            throw new NotImplementedException();
        

        //public async Task<Movie> GetMovieAsync(string id)
        //{
            //Anrop till ditt API
            //GET
            var movie = new RestClient($"https://localhost:5001/api/Movie/{id}");
            movie.Timeout = -1;
            var request = new RestRequest(Method.GET);
            //request.Data(new Movie { })
            IRestResponse response = movie.Execute(request);
            Console.WriteLine(response.Content);

            //POST

            //DELETE

        }
    }
}




