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

        public List<Movie> _movies = new List<Movie>()
            {
                new Movie { Id = "Movie_1", Title = "The big pineapple", Description = "The story about the big pineapple.", Producer="Anna Andersson", ReleaseDate = "2020" },
                new Movie { Id = "Movie_2", Title = "The medium mango", Description = "The story about the medium mango.", Producer="", ReleaseDate = "2021" },
                new Movie { Id = "Movie_3", Title = "The small apple", Description = "The story about the small apple.", Producer="", ReleaseDate = "2019" },

            };

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
                        var movies = _movieService.GetMoviesAsync();
                        break;
   
                }
            }
        }
        //GET
        public void GetMovie()
        {
            /*Console.Clear();

                    Console.WriteLine("- - - - - - - - - - - - - - ENTER ID TO GET MOVIE - - - - - - - - - - - - - - -");
                    Console.WriteLine();
                    Console.WriteLine("ID: 58611129-2dbc-4a81-a72f-77ddfc1b1b49 ");// For the movie: My Neighbour Totoro"
                    Console.WriteLine();
                    Console.WriteLine("ID: ebbb6b7c-945c-41ee-a792-de0e43191bd8 ");//For the movie: Porco Rosso
                    Console.WriteLine();
                    Console.WriteLine("ID: dc2e6bd1-8156-4886-adff-b39e6043af0c ");//For the movie: Spirited Away
                    Console.WriteLine();
                    Console.WriteLine("ID: cd3d059c-09f4-4ff3-8d63-bc765a5184fa ");//For the movie: Howl's Moving Castle
                    Console.WriteLine();
                    Console.WriteLine("ID: 12cfb892-aac0-4c5b-94af-521852e46d6a ");//For the movie: Grave of the Fireflies
                    Console.WriteLine();
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - -");
            
            Console.Clear();*/
        }
        //POST
        public void PostMovie()
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
        //}
    }
}

