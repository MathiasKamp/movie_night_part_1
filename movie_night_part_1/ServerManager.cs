using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;
using System.Net.Sockets;

namespace movie_night_part_1
{
    public static class ServerManager
    {
        private static string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MoviesDB;Integrated Security=True";


        public static List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();

            using (SqlConnection connection = new SqlConnection(cs))

            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select mov_id, mov_title, mov_description, mov_year from movie", connection);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = (int) rdr["mov_id"];
                    string title = (string) rdr["mov_title"];
                    string description = (string) rdr["mov_description"];
                    int year = (int) rdr["mov_year"];
                    Movie m = new Movie() {Mov_id = id, Mov_title = title, Mov_description = description, Mov_year = year};

                    movies.Add(m);

                }
            }
            return movies;
        }

        public static List<Actor> getActors()
        {
            List<Actor> actors = new List<Actor>();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select act_id, act_fname, act_lname from actor", connection);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = (int)rdr["act_id"];
                    string fname = (string)rdr["act_fname"];
                    string lname = (string)rdr["act_lname"];

                    Actor a = new Actor() {Act_id = id, act_fname = fname, act_lname = lname};

                    actors.Add(a);

                }

            }
            return actors;
        }

        public static List<Movie> GetMoviesWithSearch(string search)
        {
            List<Movie> movies = new List<Movie>();

            using (SqlConnection connection = new SqlConnection(cs))

            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select mov_id, mov_title, mov_description, mov_year from movie where mov_title like @search", connection);

                SqlParameter sp = new SqlParameter();
                sp.ParameterName = "@search";
                sp.Value = "%" + search + "%";
                cmd.Parameters.Add(sp);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = (int)rdr["mov_id"];
                    string title = (string)rdr["mov_title"];
                    string description = (string)rdr["mov_description"];
                    int year = (int)rdr["mov_year"];
                   
                    Movie m = new Movie() { Mov_id = id, Mov_title = title, Mov_description = description, Mov_year = year };

                    movies.Add(m);

                }
            }
            return movies;
        }

        public static List<Actor> getActorsWithSearch(string search_actname)
        {
            List<Actor> actors = new List<Actor>();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select * from actor where act_fname like @search_actname", connection);
                SqlParameter sp = new SqlParameter();
                sp.ParameterName = "@search_actname";
                sp.Value = search_actname + "%";
                cmd.Parameters.Add(sp);


                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = (int)rdr["act_id"];
                    string fname = (string)rdr["act_fname"];
                    string lname = (string)rdr["act_lname"];

                    Actor a = new Actor() { Act_id = id, act_fname = fname, act_lname = lname };

                    actors.Add(a);

                }

            }
            return actors;
        }

        public static List<Movie> GetMoviesWithGenreRomance()
        {
            List<Movie> movies = new List<Movie>();

            using (SqlConnection connection = new SqlConnection(cs))

            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("select movie.mov_id, genre.gen_id, mov_year, movie.mov_title, genre.gen_type from movie join mov_genre on movie.mov_id = mov_genre.mov_id join genre on genre.gen_id = mov_genre.gen_id where gen_type like 'romance'", connection);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int mov_id = (int)rdr["mov_id"];
                    int gen_id = (int) rdr["gen_id"];
                    string gen_type = (string) rdr["gen_type"];
                    string mov_title = (string)rdr["mov_title"];
                    int mov_year = (int)rdr["mov_year"];
                    Movie m = new Movie() { Mov_id = mov_id, Mov_title = mov_title, Mov_year = mov_year, Gen_id = gen_id, Gen_type = gen_type};

                    movies.Add(m);

                }
            }
            return movies;
        }

    }
}