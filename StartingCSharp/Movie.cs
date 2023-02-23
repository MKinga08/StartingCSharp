using System;
namespace StartingCSharp
{
    public class Movie
    {
        public string title, director;
        public string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "R" || value == "G")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }

}
