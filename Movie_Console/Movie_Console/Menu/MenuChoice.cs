using Movie_Console.MovieAPI;
using Movie_Console.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Console.Menu
{
    public class MenuChoice
    {
        private readonly IMovieService _movieService;
        public MenuChoice(IMovieService movieService)
        {
            _movieService = movieService;
        }

        //public List<Movie> _movies = new List<Movie>()
        //    {
        //        new Movie { Id = "Movie_1", Title = "The big pineapple", Description = "The story about the big pineapple.", Producer="Anna Andersson", ReleaseDate = "2020" },
        //        new Movie { Id = "Movie_2", Title = "The medium mango", Description = "The story about the medium mango.", Producer="", ReleaseDate = "2021" },
        //        new Movie { Id = "Movie_3", Title = "The small apple", Description = "The story about the small apple.", Producer="", ReleaseDate = "2019" },

        //    };

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
                        var movies = _movieService.GetMoviesAsync();
                        List<Movie> movieList = new List<Movie>();
                        foreach (Movie m in movieList)
                        {
                            movieList.Add(m);
                        }

                        Console.WriteLine(" i) ENTER ID TO GET MOVIE ");
                        Console.WriteLine(" X) RETURN TO MAIN MENU ");
                        Console.ReadLine();

                        switch (Console.ReadLine())
                        {
                            case "i":
                                //GET ID
                                Console.Clear();
                                //var movieId = _movieService.GetMovieAsync();
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

                        //var movie = new Movie { Id = id, Title = movieTitle, ReleaseDate = releaseYear, Producer = producer, Description = description };
                        break;
                    //DELETE
                    case "3":
                        Console.WriteLine("ENTER ID OF MOVIE TO DELETE MOVIE: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
        //POST
        /*public void PostMovie()
        {
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
        }

        //DELETE
        //public bool DeleteMovie(MovieModel model)
        //{
        //}*/
    


