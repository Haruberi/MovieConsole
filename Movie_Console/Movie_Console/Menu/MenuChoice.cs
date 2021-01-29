using Movie_Console.MovieAPI;
using Movie_Console.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Movie_Console.Menu
{
    public class MenuChoice
    {
        private readonly IMovieService _movieService;
        public MenuChoice(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - WELCOME ! - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - - - - - PRESS 1 TO GET MOVIES - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            var choice = Console.ReadLine();

            while (!string.IsNullOrEmpty(choice))
            {
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        var selectedMovie = DisplayMovies();
                        DisplayMovie(selectedMovie);

                        Console.WriteLine("Press any key to return to main menu");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private string DisplayMovies()
        {
            var movies = Task.Run(() => _movieService.GetMoviesAsync()).Result;

            foreach (Movie m in movies)
            {
                Console.WriteLine($"Movie ID:  {m.Id}");
                Console.WriteLine();
                Console.WriteLine($"Movie Title: {m.Title}");
                Console.WriteLine();
                Console.WriteLine($"Movie Description: {m.Description}");
                Console.WriteLine();
                Console.WriteLine($"Movie Producer: {m.Producer}");
                Console.WriteLine();
                Console.WriteLine($"Movie Release date: {m.ReleaseDate}");
            }
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - ENTER ID TO GET INFORMATION ABOUT ONE SPECIFIC MOVIE - - - - - - - ");
            Console.WriteLine();
            var input = Console.ReadLine();

            return input;
        }

        private void DisplayMovie(string input)
        {

            var selectedMovie = Task.Run(() => _movieService.GetMovieAsync(input)).Result;
            Console.WriteLine($"Movie Id: {selectedMovie.Data.Id}");
            Console.WriteLine();
            Console.WriteLine($"Movie Title: {selectedMovie.Data.Title}");
            Console.WriteLine();
            Console.WriteLine($"Movie Description: {selectedMovie.Data.Description}");
            Console.WriteLine();
            Console.WriteLine($"Movie Producer: {selectedMovie.Data.Producer}");
            Console.WriteLine();
            Console.WriteLine($"Movie Release Date: {selectedMovie.Data.ReleaseDate}");

        }
    }
}


