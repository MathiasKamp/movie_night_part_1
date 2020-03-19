using System.Collections.Generic;

namespace movie_night_part_1
{
    public class Movie
    {
        // Attributes to define an Movie Object
        public int Mov_id { get; set; }
        public int Mov_year { get; set; }
        public string Mov_title { get; set; }
        public string Mov_description { get; set; }

        // genre attributes to define the genre of the movie
        public int Gen_id { get; set; }
        public string Gen_type { get; set; }


    }
}