using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Movie_Console.MovieAPI;
using System.Net.Http.Headers;
using Movie_Console.Interface;

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

        //Post
        static async Task<Uri> CreateMovieAsync(Movie movie)
        {
            HttpResponseMessage response = await movie.PostAsJsonAsync(
                "api/movies", movie);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }
        //Get
        static async Task<Movie> GetMovieAsync(string path)
        {
            Movie movie = null;
            HttpResponseMessage response = await movie.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                movie = await response.Content.ReadAsAsync<Movie>();
            }
            return movie;
        }
        //Update
        static async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            HttpResponseMessage response = await movie.PutAsJsonAsync(
                $"api/movies/{movie.Id}", movie);
            response.EnsureSuccessStatusCode();

            movie = await response.Content.ReadAsAsync<Movie>();
            return movie;
        }
        //Delete

        static async Task<HttpStatusCode> DeleteMovieAsync(string id)
        {
            HttpResponseMessage response = await movie.DeleteAsync(
                $"api/movies{id}");
            return response.StatusCode;
        }

        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        public static async Task RunAsync()
        {
            //Create port for localhost
            movie.BaseAddress = new Uri("");
            movie.DefaultRequestHeaders.Accept.Clear();
            movie.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(""));

            try
            {
                //CREATE NEW MOVIE
                //test
                Movie movie = new Movie
                {
                    Id = "Movie_1",
                    MovieTitle = "The big pineapple",
                    ReleaseYear = 2021
                };

                var url = await CreateMovieAsync(movie);
                Console.WriteLine($"Created at {url}");

                //GET
                movie = await GetMovieAsync(url.PathAndQuery);
                ShowMovie(movie);

                //UPDATE

                //GET UPDATE
                movie = await GetMovieAsync(url.PathAndQuery);
                ShowMovie(movie);

                //DELETE
                var statusCode = await DeleteMovieAsync(movie.Id);
                Console.WriteLine($"Deleted (HTTP Status={(int)statusCode})");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }


    }
}