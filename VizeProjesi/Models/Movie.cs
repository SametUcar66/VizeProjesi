namespace VizeProjesi.Models
{
    public class Movie
    {
        // Veritabanı birincil anahtarı (Primary Key) simülasyonu
        public int Id { get; set; }

        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Mantıksal işlemler (if-else) yapabilmek için puan özelliği ekledim
        public double IMDBScore { get; set; }
    }
}