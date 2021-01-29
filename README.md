# MovieConsole
Connected to Repository Movies

What the application do:
Includes Error Handling

Uses S in SOLID:
In class MenuChoice
- private void DisplayMovies()
- private void DisplayMovie(string input)

Connects to the API thorugh localhost in the interface IMovieService
- public async GetMoviesAsync() - Get all the movies
- public async GetMovieAsync(string id) - Get one movie from an ID

Add the same properties from the repository Movies
- In the public class Movie

How to use:

Start project
- Enter main menu
- Get greeting and menu choice
- Press 1 to get a list of all movies
(Get output of all movies)
- Enter ID to get information about only one specific movie 
(Get output with information about the selected movie from the ID)
- Press any key to quit
(Exit the Console)

