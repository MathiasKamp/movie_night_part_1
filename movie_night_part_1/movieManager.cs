using System.Collections.Generic;

namespace movie_night_part_1
{
    static public class movieManager
    {

        // Method returns a list of movies with the GetMovies() method
        public static List<Movie> GetMovies()
        {
            return ServerManager.GetMovies();
        }

        // returns a list of actors with the GetActors() method
        public static List<Actor> GetActors()
        {
            return ServerManager.getActors();
        }

        // gets a list of movies where fast & has to be in the movie title
        public static List<Movie> GetMoviesWithSearch()
        {
            return ServerManager.GetMoviesWithSearch("fast &");
        }

        // gets a list of actors where there has to be an l in the name
        public static List<Actor> GetActorsWithSearch()
        {
            return ServerManager.getActorsWithSearch("l");
        }
        // gets a list of movies where the genre is romance
        public static List<Movie> GetMoviesWithGenreRomance()
        {
            return ServerManager.GetMoviesWithGenreRomance();
        }
    }
}