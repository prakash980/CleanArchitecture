namespace CleanArchitecture.Domain
{
    public class Movie
    {
        // public parameterless constructors
        public Movie()
        {

        }

        //public parameter constructor
        public Movie(int movieId, string name, int cost)
        {
            this.MovieId = movieId;
            this.Name = name;
            this.Cost = cost;
        }

        public int MovieId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
