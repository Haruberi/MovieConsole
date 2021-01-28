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
            Console.WriteLine("- - - - - - - - - - - - - - - - - - WELCOME- - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - - - - - - CHOOSE AN OPTION - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("1) GET MOVIES");
            Console.WriteLine("2) POST MOVIE");
            Console.WriteLine("3) DELETE MOVIE");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - - - - - - SELECT AN OPTION - - - - - - - - - - - - - - - - -");
            var choice = Console.ReadLine();

            while (!string.IsNullOrEmpty(choice))
            {
                switch (choice)
                {
                    //GET
                    case "1":
                        Console.Clear();

                        var movieList = _movieService.GetMoviesAsync();
                        List<Movie> movies = new List<Movie>();
                        foreach (Movie m in movies)
                        {
                            Console.WriteLine(movieList);
                        }

                        Console.WriteLine(" i) ENTER ID TO GET MOVIE ");
                        Console.WriteLine(" X) RETURN TO MAIN MENU ");
                        Console.ReadLine();

                        switch (Console.ReadLine())
                        {
                            case "i":
                                //GET ID
                                Console.Clear();
                                var getMovieID = _movieService.GetMovieAsync(movieList.Id.ToString());
                                foreach (var movie in getMovieID)
                                {
                                    Console.WriteLine("ENTER ID TO GET A SPECIFIC MOVIE : " + getMovieID.GetType().GetProperties());
                                    Console.ReadLine();
                                }
                                break;

                            case "X":
                                //RETURN TO MAIN MENU
                                
                                Console.Clear();

                                Console.WriteLine();
                                break;
                            default:
                                Console.WriteLine();
                                break;
                        }

                        break;

                    //POST
                    case "2":
                        Console.Clear();
                        var createMovie = _movieService.CreateMovieAsync(createMovie.Id.ToString());

                        Console.WriteLine("ENTER ID OF MOVIE : ");
                        var id = Console.ReadLine();
                        Console.WriteLine("ENTER TITLE OF MOVIE : ");
                        var movieTitle = Console.ReadLine();
                        Console.WriteLine("ENTER RELEASE YEAR : ");
                        var releaseYear = Console.ReadLine();
                        Console.WriteLine("ENTER PRODUCER : ");
                        var producer = Console.ReadLine();
                        Console.WriteLine("ENTER DESCRIPTION : ");
                        var description = Console.ReadLine();

                        var movie = new Movie { Id = id, Title = movieTitle, ReleaseDate = releaseYear, Producer = producer, Description = description };
                        break;

                    //DELETE
                    case "3":
                        Console.Clear();

                        Console.WriteLine("ENTER ID OF MOVIE TO DELETE A SPECIFIC MOVIE : ");
                        Console.ReadLine();
                        while (true)
                        {

                        }

                        break;
                }
            }
        }
    }
}


