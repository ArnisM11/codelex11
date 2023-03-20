namespace Exercise4
{
    public class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title,string studio,string rating)
        {
            this._title = title;
            this._studio = studio;
            this._rating = rating;
        }

        public Movie(string title, string studio)
        {
            this._title = title;
            this._studio = studio;
            this._rating = "PG";
        }

        public Movie[] GetPG(Movie[] arrayOfMovies)
        {
            Movie[] result = Array.Empty<Movie>();
            for(int i = 0; i < arrayOfMovies.Length; i++)
            {
                if (arrayOfMovies[i]._rating == "PG")
                {
                    result[i] = arrayOfMovies[i];
                }
            }
            return result;
        }
        public void PrintMovie()
        {
            Console.WriteLine(_title + " " + _studio + " " + _rating);
        }
        static void Main(string[] args)
        {
            Movie casino = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie glass = new Movie("Glass", "Buena Vista International", "PG13");
            Movie spider = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
            casino.PrintMovie();
            glass.PrintMovie();
            spider.PrintMovie();
            Movie[] listOfMovies = new Movie[] { casino, glass, spider };
            Console.ReadKey();
        }

    }
}