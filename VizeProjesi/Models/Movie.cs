namespace VizeProjesi.Models
{
    public class Movie
    {
        // birincil anahtar
        public int Id { get; set; }

        // film bilgileri
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }

        // puanlama
        public double IMDBScore { get; set; }
    }
}