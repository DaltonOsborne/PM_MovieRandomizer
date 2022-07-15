namespace PM_MovieRandomizer.Models
{
    public class Movie
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Rating Rating { get; set; }
        public double OpeningWeekendSales { get; set; }

        public double TotalSales { get; set; }
    }
    public enum Rating
    {
        E
    }
}
