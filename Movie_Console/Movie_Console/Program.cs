using System;
using System.Net.Http;
using Movie_Console.MovieAPI;

namespace Movie_Console
{
    class Program
    {
        static HttpClient movie = new HttpClient();

        static void ShowMovie(Movie movie)
        {
            Console.WriteLine($"ID: {Id}" +
            $"\n Movie title: {MovieTitle}" +
            $"\n Release year: {ReleaseYear}");
        }

        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            //localhost link
            try
            {
                //Create new movie
                Movie movie = new Movie
                {
                    Id="1",
                    MovieTitle="The banana and me",
                    ReleaseYear=2021
                };
                var url=await CreateMovieAsync
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
