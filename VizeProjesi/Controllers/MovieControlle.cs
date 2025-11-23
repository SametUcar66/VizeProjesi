using Microsoft.AspNetCore.Mvc;
using VizeProjesi.Models;
using System.Collections.Generic;
using System.Linq; //SİLME!!!!!!!

namespace VizeProjesi.Controllers
{
    public class MovieController : Controller
    {
        // 50 filmlik dev liste oluşturuldu, isimler orijinal haliyle girildi
        public static List<Movie> _movies = new List<Movie>
        {
            // --- THE DARK KNIGHT TRILOGY (AKSİYON) ---
            new Movie { Id = 1, Title = "Batman Begins", Category = "Aksiyon", Director = "Christopher Nolan", Description = "Bruce Wayne'in Batman'e dönüşüm süreci.", ImageUrl = "batman1.jpg", IMDBScore = 8.2 },
            new Movie { Id = 2, Title = "The Dark Knight", Category = "Aksiyon", Director = "Christopher Nolan", Description = "Joker, Gotham'ı kaosa sürüklüyor.", ImageUrl = "batman2.jpg", IMDBScore = 9.0 },
            new Movie { Id = 3, Title = "The Dark Knight Rises", Category = "Aksiyon", Director = "Christopher Nolan", Description = "Bane şehri ele geçiriyor.", ImageUrl = "batman3.jpg", IMDBScore = 8.4 },

            // --- JOHN WICK SAGA (AKSİYON) ---
            new Movie { Id = 4, Title = "John Wick", Category = "Aksiyon", Director = "Chad Stahelski", Description = "Emekli tetikçi geri dönüyor.", ImageUrl = "jw1.jpg", IMDBScore = 7.4 },
            new Movie { Id = 5, Title = "John Wick: Chapter 2", Category = "Aksiyon", Director = "Chad Stahelski", Description = "Roma'da zorunlu görev.", ImageUrl = "jw2.jpg", IMDBScore = 7.5 },
            new Movie { Id = 6, Title = "John Wick: Chapter 3 - Parabellum", Category = "Aksiyon", Director = "Chad Stahelski", Description = "Herkes onun peşinde.", ImageUrl = "jw3.jpg", IMDBScore = 7.4 },
            new Movie { Id = 7, Title = "John Wick: Chapter 4", Category = "Aksiyon", Director = "Chad Stahelski", Description = "Özgürlük savaşı.", ImageUrl = "jw4.jpg", IMDBScore = 7.8 },

            // --- HARRY POTTER SERIES (FANTASTİK) ---
            new Movie { Id = 8, Title = "Harry Potter and the Sorcerer's Stone", Category = "Fantastik", Director = "Chris Columbus", Description = "Büyücülük dünyasına giriş.", ImageUrl = "hp1.jpg", IMDBScore = 7.6 },
            new Movie { Id = 9, Title = "Harry Potter and the Chamber of Secrets", Category = "Fantastik", Director = "Chris Columbus", Description = "Mirasçının dönüşü.", ImageUrl = "hp2.jpg", IMDBScore = 7.4 },
            new Movie { Id = 10, Title = "Harry Potter and the Prisoner of Azkaban", Category = "Fantastik", Director = "Alfonso Cuarón", Description = "Sirius Black kaçtı.", ImageUrl = "hp3.jpg", IMDBScore = 7.9 },
            new Movie { Id = 11, Title = "Harry Potter and the Goblet of Fire", Category = "Fantastik", Director = "Mike Newell", Description = "Üçbüyücü turnuvası.", ImageUrl = "hp4.jpg", IMDBScore = 7.7 },
            new Movie { Id = 12, Title = "Harry Potter and the Order of the Phoenix", Category = "Fantastik", Director = "David Yates", Description = "Ordu kuruluyor.", ImageUrl = "hp5.jpg", IMDBScore = 7.5 },
            new Movie { Id = 13, Title = "Harry Potter and the Half-Blood Prince", Category = "Fantastik", Director = "David Yates", Description = "Voldemort'un geçmişi.", ImageUrl = "hp6.jpg", IMDBScore = 7.6 },
            new Movie { Id = 14, Title = "Harry Potter and the Deathly Hallows: Part 1", Category = "Fantastik", Director = "David Yates", Description = "Hortkuluk avı.", ImageUrl = "hp7.jpg", IMDBScore = 7.7 },
            new Movie { Id = 15, Title = "Harry Potter and the Deathly Hallows: Part 2", Category = "Fantastik", Director = "David Yates", Description = "Son savaş.", ImageUrl = "hp8.jpg", IMDBScore = 8.1 },

            // --- STAR WARS SAGA (BİLİM KURGU) ---
            new Movie { Id = 16, Title = "Star Wars: Episode I - The Phantom Menace", Category = "Bilim Kurgu", Director = "George Lucas", Description = "Anakin'in keşfi.", ImageUrl = "sw1.jpg", IMDBScore = 6.5 },
            new Movie { Id = 17, Title = "Star Wars: Episode II - Attack of the Clones", Category = "Bilim Kurgu", Director = "George Lucas", Description = "Klon savaşları.", ImageUrl = "sw2.jpg", IMDBScore = 6.6 },
            new Movie { Id = 18, Title = "Star Wars: Episode III - Revenge of the Sith", Category = "Bilim Kurgu", Director = "George Lucas", Description = "Darth Vader doğuyor.", ImageUrl = "sw3.jpg", IMDBScore = 7.6 },
            new Movie { Id = 19, Title = "Star Wars: Episode IV - A New Hope", Category = "Bilim Kurgu", Director = "George Lucas", Description = "Luke Skywalker sahnede.", ImageUrl = "sw4.jpg", IMDBScore = 8.6 },
            new Movie { Id = 20, Title = "Star Wars: Episode V - The Empire Strikes Back", Category = "Bilim Kurgu", Director = "Irvin Kershner", Description = "İmparatorluk saldırıyor.", ImageUrl = "sw5.jpg", IMDBScore = 8.7 },
            new Movie { Id = 21, Title = "Star Wars: Episode VI - Return of the Jedi", Category = "Bilim Kurgu", Director = "Richard Marquand", Description = "Jedi'ın dönüşü.", ImageUrl = "sw6.jpg", IMDBScore = 8.3 },

            // --- LORD OF THE RINGS (FANTASTİK) ---
            new Movie { Id = 22, Title = "The Lord of the Rings: The Fellowship of the Ring", Category = "Fantastik", Director = "Peter Jackson", Description = "Yüzük kardeşliği.", ImageUrl = "lotr1.jpg", IMDBScore = 8.8 },
            new Movie { Id = 23, Title = "The Lord of the Rings: The Two Towers", Category = "Fantastik", Director = "Peter Jackson", Description = "İki kule savaşı.", ImageUrl = "lotr2.jpg", IMDBScore = 8.8 },
            new Movie { Id = 24, Title = "The Lord of the Rings: The Return of the King", Category = "Fantastik", Director = "Peter Jackson", Description = "Kralın dönüşü.", ImageUrl = "lotr3.jpg", IMDBScore = 9.0 },

            // --- THE MATRIX TRILOGY (BİLİM KURGU) ---
            new Movie { Id = 25, Title = "The Matrix", Category = "Bilim Kurgu", Director = "Lana & Lilly Wachowski", Description = "Simülasyon teorisi.", ImageUrl = "matrix1.jpg", IMDBScore = 8.7 },
            new Movie { Id = 26, Title = "The Matrix Reloaded", Category = "Bilim Kurgu", Director = "Lana & Lilly Wachowski", Description = "Neo güçleniyor.", ImageUrl = "matrix2.jpg", IMDBScore = 7.2 },
            new Movie { Id = 27, Title = "The Matrix Revolutions", Category = "Bilim Kurgu", Director = "Lana & Lilly Wachowski", Description = "Makinelerle son savaş.", ImageUrl = "matrix3.jpg", IMDBScore = 6.7 },

            // --- MARVEL UNIVERSE (AKSİYON) ---
            new Movie { Id = 28, Title = "Iron Man", Category = "Aksiyon", Director = "Jon Favreau", Description = "Tony Stark'ın başlangıcı.", ImageUrl = "ironman.jpg", IMDBScore = 7.9 },
            new Movie { Id = 29, Title = "The Avengers", Category = "Aksiyon", Director = "Joss Whedon", Description = "Kahramanlar toplanıyor.", ImageUrl = "avengers1.jpg", IMDBScore = 8.0 },
            new Movie { Id = 30, Title = "Avengers: Infinity War", Category = "Aksiyon", Director = "Russo Brothers", Description = "Thanos geliyor.", ImageUrl = "infinitywar.jpg", IMDBScore = 8.4 },
            new Movie { Id = 31, Title = "Avengers: Endgame", Category = "Aksiyon", Director = "Russo Brothers", Description = "Final savaşı.", ImageUrl = "endgame.jpg", IMDBScore = 8.4 },
            new Movie { Id = 32, Title = "Spider-Man: No Way Home", Category = "Aksiyon", Director = "Jon Watts", Description = "Çoklu evren açılıyor.", ImageUrl = "spidermannwh.jpg", IMDBScore = 8.2 },

            // --- ANIMATION CLASSICS (ANİMASYON) ---
            new Movie { Id = 33, Title = "Toy Story", Category = "Animasyon", Director = "John Lasseter", Description = "Oyuncakların dünyası.", ImageUrl = "toystory.jpg", IMDBScore = 8.3 },
            new Movie { Id = 34, Title = "Finding Nemo", Category = "Animasyon", Director = "Andrew Stanton", Description = "Kayıp balık aranıyor.", ImageUrl = "nemo.jpg", IMDBScore = 8.1 },
            new Movie { Id = 35, Title = "WALL·E", Category = "Animasyon", Director = "Andrew Stanton", Description = "Gelecekteki aşk.", ImageUrl = "walle.jpg", IMDBScore = 8.4 },
            new Movie { Id = 36, Title = "The Lion King", Category = "Animasyon", Director = "Roger Allers", Description = "Simba'nın hikayesi.", ImageUrl = "lionking.jpg", IMDBScore = 8.5 },
            new Movie { Id = 37, Title = "Spider-Man: Into the Spider-Verse", Category = "Animasyon", Director = "Peter Ramsey", Description = "Örümcek evrenleri.", ImageUrl = "spiderverse.jpg", IMDBScore = 8.4 },

            // --- DRAMA & CULT CLASSICS (DRAMA) ---
            new Movie { Id = 38, Title = "The Godfather", Category = "Drama", Director = "Francis Ford Coppola", Description = "Mafya efsanesi.", ImageUrl = "godfather.jpg", IMDBScore = 9.2 },
            new Movie { Id = 39, Title = "The Shawshank Redemption", Category = "Drama", Director = "Frank Darabont", Description = "Umudun hikayesi.", ImageUrl = "shawshank.jpg", IMDBScore = 9.3 },
            new Movie { Id = 40, Title = "Pulp Fiction", Category = "Drama", Director = "Quentin Tarantino", Description = "Şiddet ve mizah.", ImageUrl = "pulpfiction.jpg", IMDBScore = 8.9 },
            new Movie { Id = 41, Title = "Fight Club", Category = "Drama", Director = "David Fincher", Description = "Tüketim toplumuna isyan.", ImageUrl = "fightclub.jpg", IMDBScore = 8.8 },
            new Movie { Id = 42, Title = "Forrest Gump", Category = "Drama", Director = "Robert Zemeckis", Description = "Bir adamın inanılmaz hayatı.", ImageUrl = "forrestgump.jpg", IMDBScore = 8.8 },
            new Movie { Id = 43, Title = "The Truman Show", Category = "Drama", Director = "Peter Weir", Description = "Hayat bir TV şovu.", ImageUrl = "truman.jpg", IMDBScore = 8.2 },
            new Movie { Id = 44, Title = "Parasite", Category = "Drama", Director = "Bong Joon Ho", Description = "Sınıf çatışması.", ImageUrl = "parasite.jpg", IMDBScore = 8.5 },

            // --- ANIME SELECTIONS (ANİME) ---
            new Movie { Id = 45, Title = "Chainsaw Man: Reze Arc", Category = "Anime", Director = "Ryu Nakayama", Description = "Denji ve Reze.", ImageUrl = "reze.jpg", IMDBScore = 9.1 },
            new Movie { Id = 46, Title = "Spirited Away", Category = "Anime", Director = "Hayao Miyazaki", Description = "Ruhların kaçışı.", ImageUrl = "spirited.jpg", IMDBScore = 8.6 },
            new Movie { Id = 47, Title = "Your Name", Category = "Anime", Director = "Makoto Shinkai", Description = "Zaman ve mekan.", ImageUrl = "yourname.jpg", IMDBScore = 8.4 },

            // --- HORROR & THRILLER (KORKU) ---
            new Movie { Id = 48, Title = "The Shining", Category = "Korku", Director = "Stanley Kubrick", Description = "Otelde delilik.", ImageUrl = "shining.jpg", IMDBScore = 8.4 },
            new Movie { Id = 49, Title = "Get Out", Category = "Korku", Director = "Jordan Peele", Description = "Psikolojik gerilim.", ImageUrl = "getout.jpg", IMDBScore = 7.7 },
            new Movie { Id = 50, Title = "Psycho", Category = "Korku", Director = "Alfred Hitchcock", Description = "Motel cinayeti.", ImageUrl = "psycho.jpg", IMDBScore = 8.5 }
        };


        public IActionResult Index(string category)
        {
            var filmler = _movies;

            if (!string.IsNullOrEmpty(category))
            {
                filmler = _movies.Where(x => x.Category == category).ToList();
            }

            return View(filmler);
        }

        // detay verisi
        public IActionResult Details(int id)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);

            if (movie == null)
            {
                return RedirectToAction("Index");
            }

            return View(movie);
        }
    }
}