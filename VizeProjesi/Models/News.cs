namespace VizeProjesi.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; } // Ana sayfada görünen kısa yazı
        public string ImageUrl { get; set; }
        public string Date { get; set; }

        // Yeni eklediğimiz alan: Haberin uzun metni
        public string Content { get; set; }
    }
}