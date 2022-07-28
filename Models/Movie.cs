using System.ComponentModel.DataAnnotations.Schema;

namespace PM_MovieRandomizer.Models
{
    public class Movie
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Rating Rating { get; set; }
        public double OpeningWeekendSales { get; set; }
        [NotMapped]
        public double TotalSales { get; set; }
        [NotMapped]
        public string Director { get { return "Kunihiko Yuyama"; } }
        [NotMapped]
        public string Url { get { return $"https://www.google.com/search?q=rent {Title}";  } }
    }
    public enum Rating
    {
        E
    }
}
