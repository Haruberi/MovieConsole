using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Movie_Console.MovieAPI;
using System.Net.Http.Headers;
using Movie_Console.Interface;

namespace Movie_Console
{
    class Program:Movie
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Main method");
        }
        //static HttpClient movie = new HttpClient();

        public void ShowMovie(Movie movie)
        {
            /*Console.WriteLine($"ID: {Id}" +
            $"\n Movie title: {MovieTitle}" +
            $"\n Release year: {ReleaseYear}" +
            $"\n Description: {Description}"
            );*/
        }

        //Create port for localhost
        //movie.BaseAddress = new Uri("");
        //movie.DefaultRequestHeaders.Accept.Clear();
        //movie.DefaultRequestHeaders.Accept.Add(
        //  new MediaTypeWithQualityHeaderValue(""));

        //try
        //{
        //CREATE NEW MOVIE
        //test
        //  Movie movie = new Movie
        //{
        //  Id = "Movie_1",
        //MovieTitle = "The big pineapple",
        //ReleaseYear = 2021
        //};

        //var url = await CreateMovieAsync(movie);
        //Console.WriteLine($"Created at {url}");

        //GET
        //movie = await GetMovieAsync(url.PathAndQuery);
        //ShowMovie(movie);

        //UPDATE

        //GET UPDATE
        //movie = await GetMovieAsync(url.PathAndQuery);
        //ShowMovie(movie);

        //DELETE
        //var statusCode = await DeleteMovieAsync(movie.Id);
        //Console.WriteLine($"Deleted (HTTP Status={(int)statusCode})");

        // }
        //catch (Exception e)
        //{

        //  Console.WriteLine(e.Message);
        //}

        //Console.WriteLine();



        /*
        public List<Movie> GetMovies()
        {
            return _movies;
        }
        
        public Movie CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
         
         */


    }
}