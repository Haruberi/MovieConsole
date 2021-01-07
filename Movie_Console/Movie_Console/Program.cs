using System;
using System.Net.Http;
using System.Threading.Tasks;
using Movie_Console.MovieAPI;

namespace Movie_Console
{
    class Program : Movie
    {
        static HttpClient movie = new HttpClient();

        public void ShowMovie(Movie movie)
        {
            Console.WriteLine($"ID: {Id}" +
            $"\n Movie title: {MovieTitle}" +
            $"\n Release year: {ReleaseYear}");
        }
    }
}