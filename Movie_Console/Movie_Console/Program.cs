using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Movie_Console.MovieAPI;
using System.Net.Http.Headers;
using Movie_Console.Interface;
using Movie_Console.Menu;
using Microsoft.Extensions.DependencyInjection;

namespace Movie_Console
{
    class Program : Movie
    {
        public static void Main(String[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IMovieService, MovieService>()
                .BuildServiceProvider();

            var movieService = serviceProvider.GetService<IMovieService>();

            var menu = new MenuChoice(movieService);
            menu.DisplayMenu();

        }
    }
}