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

                    case "1":
                        Console.Clear();
                        void DisplayMovies()
                        {
                            var movies = Task.Run(() => _movieService.GetMoviesAsync()).Result;

                            foreach (Movie m in movies)
                            {
                                Console.WriteLine($"Movie ID:  {m.Id}");
                                Console.WriteLine($"Movie Title: {m.Title}");
                                Console.WriteLine($"Movie Description: {m.Description}");
                                Console.WriteLine($"Movie Producer: {m.Producer}");
                                Console.WriteLine($"Movie Release date: {m.ReleaseDate}");
                            }

                            Console.WriteLine(" i) ENTER ID TO GET MOVIE ");
                            Console.WriteLine(" X) RETURN TO MAIN MENU ");
                            var input = Console.ReadLine();
                        }
                        break;

                        //void DisplayMovie()
                        //{

                        //    var selectedMovie = Task.Run(() => _movieService.GetMovieAsync(string id)).Result;
                        //    Console.WriteLine($"Movie Id: {selectedMovie.Id}");
                        //    Console.WriteLine($"Movie Title: {selectedMovie.Title}");
                        //    Console.WriteLine($"Movie Description: {selectedMovie.Description}");
                        //    Console.WriteLine($"Movie Producer: {selectedMovie.Producer}");
                        //    Console.WriteLine($"Movie Release Date: {selectedMovie.RealeaseDate}");

                        //}

                        break;
                        Console.WriteLine("Press any key to return to main menu");
                        Console.ReadLine();
                    //POST
                    case "2":
                        //Console.Clear();

                        //void AddMovie()
                        //{
                        //    var createMovie = Task.Run(() => _movieService.CreateMovieAsync(id)).Result;
                        //    //var createMovie = _movieService.CreateMovieAsync(createMovie.Id.ToString());

                        //    Console.WriteLine("ENTER ID OF MOVIE : ");
                        //    var id = Console.ReadLine();
                        //    Console.WriteLine("ENTER TITLE OF MOVIE : ");
                        //    var movieTitle = Console.ReadLine();
                        //    Console.WriteLine("ENTER RELEASE YEAR : ");
                        //    var releaseYear = Console.ReadLine();
                        //    Console.WriteLine("ENTER PRODUCER : ");
                        //    var producer = Console.ReadLine();
                        //    Console.WriteLine("ENTER DESCRIPTION : ");
                        //    var description = Console.ReadLine();

                        //    var movie = new Movie { Id = id, Title = movieTitle, ReleaseDate = releaseYear, Producer = producer, Description = description };
                        //}
                        break;

                    //DELETE
                    case "3":
                        Console.Clear();
                        void DeleteMovie()
                        {
                            Console.WriteLine("ENTER ID OF MOVIE TO DELETE A SPECIFIC MOVIE : ");
                            Console.ReadLine();
                        }
                        break;
                }
            }
        }
    }
}


