using System.Collections.Generic;

namespace movie_night_part_1
{
    static public class movieManager
    {
        public static List<Movie> GetMovies()
        {
            return ServerManager.GetMovies();
        }

        public static List<Actor> GetActors()
        {
            return ServerManager.getActors();
        }

        public static List<Movie> GetMoviesWithSearch()
        {
            return ServerManager.GetMoviesWithSearch("fast &");
        }

        public static List<Actor> GetActorsWithSearch()
        {
            return ServerManager.getActorsWithSearch("l");
        }

        public static List<Movie> GetMoviesWithGenreRomance()
        {
            return ServerManager.GetMoviesWithGenreRomance();
        }
    }
}