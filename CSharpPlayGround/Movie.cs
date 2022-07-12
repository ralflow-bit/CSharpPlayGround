 using System;
 namespace CSharpPlayGround
 {
    public class Movie
    {
        public string? name{ get; set; }
        private string? rating { get; set; }
        public string? director { get; set; }
        public string? genre { get; set; }
        public Movie(string aName, string aDirector, string aRating, string aGenre)
        {
            name = aName;
            director = aDirector;
            Rating = aRating;
            genre = aGenre;
        }
       public string? Rating
       {
            get { return rating; }
            set 
            { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    Console.WriteLine("Invalid Rating");
                }
            }
       }
       

        
    }

 }

