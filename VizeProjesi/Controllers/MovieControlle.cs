using Microsoft.AspNetCore.Mvc;
using VizeProjesi.Models;
using System.Collections.Generic;
using System.Linq; // LINQ sorguları için gerekli SİLME!!!!

namespace VizeProjesi.Controllers
{
    public class MovieController : Controller
    {
        // verileri RAM üzerinde static bir listede tutuyorum.
        private static List<Movie> _movies = new List<Movie>
{
   new Movie {
                Id = 1,
                Title = "Inception",
                Director = "Christopher Nolan",
                Description = "Rüya katmanları arasında geçen psikolojik bir gerilim. Final sahnesi hala tartışma konusu.",
                ImageUrl = "inception.jpg",
                IMDBScore = 8.8
            },
            new Movie {
                Id = 2,
                Title = "Chainsaw Man: Reze Arc",
                Director = "Ryu Nakayama",
                Description = "Denji ve Reze arasındaki ilişkiyi konu alan, aksiyon dozu yüksek ve duygusal derinliği olan bir yapım.",
                ImageUrl = "reze.jpg",
                IMDBScore = 9.1 // Kişisel favorim
            },
            new Movie {
                Id = 3,
                Title = "Spider-Man 3",
                Director = "Sam Raimi",
                Description = "Peter Parker'ın simbiyot kostümüyle imtihanı. Bully Maguire dans sahnesiyle ikonikleşmiştir.",
                ImageUrl = "spiderman3.jpg",
                IMDBScore = 7.3
            },
            new Movie {
                Id = 4,
                Title = "Joker",
                Director = "Todd Phillips",
                Description = "Toplumsal çöküşün birey üzerindeki etkisini anlatan karanlık bir başyapıt.",
                ImageUrl = "joker.jpg",
                IMDBScore = 8.4
            },
            new Movie {
                Id = 5,
                Title = "Interstellar",
                Director = "Christopher Nolan",
                Description = "Görelilik teorisi ve kara delikler üzerine kurgulanmış bilim kurgu destanı.",
                ImageUrl = "interstellar.jpg",
                IMDBScore = 8.7
            },
            new Movie {
                Id = 6,
                Title = "Avengers: Endgame",
                Director = "Russo Brothers",
                Description = "Marvel evreninin 10 yıllık serüveninin epik finali.",
                ImageUrl = "avengers.jpg",
                IMDBScore = 8.4
            }
};

        public IActionResult Index() // Film listesini View katmanına model olarak gönderiyorum.
        {
            return View(_movies);
        }
        // ID parametresine göre ilgili filmi bulup detay sayfasına yönlendiriyorum.
        // LINQ FirstOrDefault metodu ile arama işlemi optimize edildi.
        public IActionResult Details(int id)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == id);

            // Eğer geçersiz bir ID gelirse (örn: URL'den elle girilirse) hata sayfasına düşmemesi için kontrol
            if (movie == null)
            {
                return RedirectToAction("Index");
            }

            return View(movie);
        }
    }
}