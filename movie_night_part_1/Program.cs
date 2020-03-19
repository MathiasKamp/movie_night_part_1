using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace movie_night_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints list of movies
            List<Movie> movies = movieManager.GetMovies();

            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.Mov_title);
            }

            // prints list of actors
            List<Actor> actors = movieManager.GetActors();

            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor.act_fname + actor.act_lname);
            }

            // prints list of movies with the search method
            List<Movie> movieSearch = movieManager.GetMoviesWithSearch();

            foreach (Movie Movieseach in movieSearch)
            {
                Console.WriteLine(Movieseach.Mov_title);
            }
            // prints list of actors with the search method
            List<Actor> actorsSearch = movieManager.GetActorsWithSearch();

            foreach (Actor actor in actorsSearch)
            {
                Console.WriteLine(actor.act_fname);
            }
            // printts list of movies with the genre romance
            List<Movie> movieGenreRomance = movieManager.GetMoviesWithGenreRomance();

            foreach (Movie movie in movieGenreRomance)
            {
                Console.WriteLine(movie.Mov_title + "  the genre is  " +movie.Gen_type);
            }
        }
    }
}