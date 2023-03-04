namespace Exercise4
{
    public class Movie
    {
        public string title;
        public string studio;
        public string rating;

        public Movie(string title,string studio,string rating)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }

        public Movie(string title, string studio)
        {
            this.title = title;
            this.studio = studio;
            this.rating = "PG";
        }

        public Movie[] GetPG(Movie[] arrayOfMovies)
        {
            Movie[] result = Array.Empty<Movie>();
            for(int i = 0; i < arrayOfMovies.Length; i++)
            {
                if (arrayOfMovies[i].rating == "PG")
                {
                    result[i] = arrayOfMovies[i];
                }
            }
            return result;
        }
        public void PrintMovie()
        {
            Console.WriteLine(title + " " + studio + " " + rating);
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