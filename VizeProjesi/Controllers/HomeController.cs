using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using VizeProjesi.Models;

namespace VizeProjesi.Controllers
{
    public class HomeController : Controller
    {
        public static List<News> _newsList = new List<News>
        {
            new News {
                Id = 1,
                Title = "Christopher Nolan'dan Yeni Film Müjdesi!",
                Summary = "Ünlü yönetmen, bir sonraki projesinin korku temalı olabileceğini açıkladı.",
                Content = "Oppenheimer ile büyük başarı yakalayan Christopher Nolan, verdiği son röportajda bir sonraki projesi hakkında ipuçları verdi. Korku türüne her zaman ilgi duyduğunu belirten yönetmen, 'Sinemanın bu karanlık tarafını keşfetmek istiyorum' dedi. Henüz resmi bir senaryo olmasa da, stüdyolar şimdiden sıraya girmiş durumda.",
                ImageUrl = "nolan_news.jpg",
                Date = "20.11.2025"
            },
            new News {
                Id = 2,
                Title = "Marvel Evreninde Şok Ayrılık",
                Summary = "Avengers serisinin sevilen oyuncusu, yeni kontratı imzalamayı reddetti.",
                Content = "Marvel Sinematik Evreni'nde dengeler değişiyor. Serinin kilit isimlerinden biri, Disney ile yapılan kontrat görüşmelerinde anlaşmaya varamadı. Kaynaklar, oyuncunun karakterin gidişatından memnun olmadığını ve artık bağımsız sinemaya yönelmek istediğini belirtiyor. Hayranlar sosyal medyada tepkili.",
                ImageUrl = "marvel_news.jpg",
                Date = "19.11.2025"
            },
            new News {
                Id = 3,
                Title = "Oscar Adayları Belli Oldu",
                Summary = "Bu sene yarış çok çekişmeli geçecek. Oppenheimer ve Barbie başa baş.",
                Content = "Sinema dünyasının en prestijli ödülleri için geri sayım başladı. Akademi, bu sabah adayları açıkladı. Beklendiği gibi 'Barbenheimer' rüzgarı listeleri domine etti. En İyi Film, En İyi Yönetmen ve En İyi Erkek Oyuncu kategorilerinde kıyasıya bir rekabet bekleniyor. Tören önümüzdeki ay gerçekleşecek.",
                ImageUrl = "oscar_news.jpg",
                Date = "18.11.2025"
            }
        };

        public IActionResult Index()
        {
            // veriler static listeden geliyor
            var vitrin = MovieController._movies.FirstOrDefault(x => x.Id == 7);
            var filmListesi = MovieController._movies;

            var model = new HomeViewModel
            {
                VitrinFilmi = vitrin,
                SliderFilmleri = filmListesi,
                Haberler = _newsList 
            };

            return View(model);
        }
        //haber detay sayfası
        public IActionResult NewsDetails(int id)
        {
            var haber = _newsList.FirstOrDefault(x => x.Id == id);

            if (haber == null)
            {
                return RedirectToAction("Index");
            }

            return View(haber);
        }
    }
}