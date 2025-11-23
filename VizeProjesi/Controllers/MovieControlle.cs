using Microsoft.AspNetCore.Mvc;
using VizeProjesi.Models;
using System.Collections.Generic;
using System.Linq;

namespace VizeProjesi.Controllers
{
    public class MovieController : Controller
    {
        // 50 filmlik liste, artık uzun ve detaylı açıklamalar içeriyor.
        public static List<Movie> _movies = new List<Movie>
        {
            // --- THE DARK KNIGHT TRILOGY (AKSİYON) ---
            new Movie { Id = 1, Title = "Batman Begins", Category = "Aksiyon", Director = "Christopher Nolan", Description = "Ailesinin cinayetine tanık olan Bruce Wayne, adaletsizlikle savaşmak için dünyayı dolaşır. Gotham'a döndüğünde, şehri yozlaşmışlıktan kurtarmak için korkuyu bir silaha dönüştürerek Batman kimliğine bürünür.", ImageUrl = "batman1.jpg", IMDBScore = 8.2 },
            new Movie { Id = 2, Title = "The Dark Knight", Category = "Aksiyon", Director = "Christopher Nolan", Description = "Joker olarak bilinen suç dehası Gotham sokaklarında kaos yarattığında, Batman, adaletsizlikle savaşma yeteneğinin en büyük psikolojik ve fiziksel testiyle yüzleşmek zorunda kalır.", ImageUrl = "batman2.jpg", IMDBScore = 9.0 },
            new Movie { Id = 3, Title = "The Dark Knight Rises", Category = "Aksiyon", Director = "Christopher Nolan", Description = "Bane adındaki acımasız bir teröristin Gotham'ı ele geçirmesiyle Bruce Wayne, sekiz yıllık sürgününden dönmek zorunda kalır. Ancak bu sefer karşısındaki düşman, onu hem fiziksel hem de zihinsel olarak yıkmayı hedefler.", ImageUrl = "batman3.jpg", IMDBScore = 8.4 },

            // --- JOHN WICK SAGA (AKSİYON) ---
            new Movie { Id = 4, Title = "John Wick", Category = "Aksiyon", Director = "Chad Stahelski", Description = "Eski bir tetikçi olan John Wick, karısından kalan son hediye olan köpeğinin öldürülmesiyle emekliliğini bozar. Yeraltı dünyasına geri dönen Wick, intikam almak için durdurulamaz bir ölüm makinesine dönüşür.", ImageUrl = "jw1.jpg", IMDBScore = 7.4 },
            new Movie { Id = 5, Title = "John Wick: Chapter 2", Category = "Aksiyon", Director = "Chad Stahelski", Description = "Kan yeminiyle bağlı olduğu eski bir arkadaşı yüzünden Roma'ya gitmek zorunda kalan John Wick, dünyanın en tehlikeli kiralık katillerine karşı hayatta kalma mücadelesi verir.", ImageUrl = "jw2.jpg", IMDBScore = 7.5 },
            new Movie { Id = 6, Title = "John Wick: Chapter 3 - Parabellum", Category = "Aksiyon", Director = "Chad Stahelski", Description = "High Table tarafından aforoz edilen ve başına 14 milyon dolar ödül konan John Wick, New York sokaklarında dünyanın en yetenekli suikastçilerine karşı amansız bir kaçış mücadelesi verir.", ImageUrl = "jw3.jpg", IMDBScore = 7.4 },
            new Movie { Id = 7, Title = "John Wick: Chapter 4", Category = "Aksiyon", Director = "Chad Stahelski", Description = "Özgürlüğünü kazanmanın bir yolunu bulan John Wick, Yüksek Şura'ya karşı savaş açar. Ancak eski dostların düşmana dönüştüğü bu savaşta, bedel her zamankinden daha ağır olacaktır.", ImageUrl = "jw4.jpg", IMDBScore = 7.8 },

            // --- HARRY POTTER SERIES (FANTASTİK) ---
            new Movie { Id = 8, Title = "Harry Potter and the Sorcerer's Stone", Category = "Fantastik", Director = "Chris Columbus", Description = "Sıradan bir çocuk olduğunu sanan Harry, 11. yaş gününde büyücü olduğunu öğrenir. Hogwarts Cadılık ve Büyücülük Okulu'na başlamasıyla, geçmişindeki karanlık sırları ve kaderini keşfedecektir.", ImageUrl = "hp1.jpg", IMDBScore = 7.6 },
            new Movie { Id = 9, Title = "Harry Potter and the Chamber of Secrets", Category = "Fantastik", Director = "Chris Columbus", Description = "Hogwarts'ta karanlık bir güç uyanır ve Sırlar Odası'nın açıldığına dair kanlı mesajlar belirir. Harry ve arkadaşları, okulu tehdit eden bu kadim kötülüğü durdurmak zorundadır.", ImageUrl = "hp2.jpg", IMDBScore = 7.4 },
            new Movie { Id = 10, Title = "Harry Potter and the Prisoner of Azkaban", Category = "Fantastik", Director = "Alfonso Cuarón", Description = "Kötü şöhretli suçlu Sirius Black, Azkaban hapishanesinden kaçar ve Harry'nin peşine düşer. Harry, hem bu tehditle hem de ruh emicilerin dondurucu etkisiyle başa çıkmak zorundadır.", ImageUrl = "hp3.jpg", IMDBScore = 7.9 },
            new Movie { Id = 11, Title = "Harry Potter and the Goblet of Fire", Category = "Fantastik", Director = "Mike Newell", Description = "Hogwarts, efsanevi Üçbüyücü Turnuvası'na ev sahipliği yapar. Harry, yaşı tutmamasına rağmen isminin kadehten çıkmasıyla kendini ölümcül görevlerin ve geri dönen Voldemort'un karşısında bulur.", ImageUrl = "hp4.jpg", IMDBScore = 7.7 },
            new Movie { Id = 12, Title = "Harry Potter and the Order of the Phoenix", Category = "Fantastik", Director = "David Yates", Description = "Voldemort'un dönüşüne inanmayan Büyü Bakanlığı, Hogwarts'ı kontrol altına alır. Harry, arkadaşlarıyla gizli bir ordu kurarak yaklaşan savaşa hazırlanmaya başlar.", ImageUrl = "hp5.jpg", IMDBScore = 7.5 },
            new Movie { Id = 13, Title = "Harry Potter and the Half-Blood Prince", Category = "Fantastik", Director = "David Yates", Description = "Harry, gizemli Melez Prens'in kitabını bulur ve bu sayede büyücülükte ustalaşır. Dumbledore ile birlikte Voldemort'un geçmişine inerek onu yenmenin anahtarını ararlar.", ImageUrl = "hp6.jpg", IMDBScore = 7.6 },
            new Movie { Id = 14, Title = "Harry Potter and the Deathly Hallows: Part 1", Category = "Fantastik", Director = "David Yates", Description = "Harry, Ron ve Hermione; Voldemort'un ölümsüzlük sırrı olan Hortkulukları bulup yok etmek için okulu terk ederler. Ancak karanlık güçler her yerde onları aramaktadır.", ImageUrl = "hp7.jpg", IMDBScore = 7.7 },
            new Movie { Id = 15, Title = "Harry Potter and the Deathly Hallows: Part 2", Category = "Fantastik", Director = "David Yates", Description = "İyiler ve kötüler arasındaki savaş Hogwarts'ta son bulur. Harry Potter, kaderindeki son düello için Voldemort ile yüzleşmek ve en büyük fedakarlığı yapmak zorundadır.", ImageUrl = "hp8.jpg", IMDBScore = 8.1 },

            // --- STAR WARS SAGA (BİLİM KURGU) ---
            new Movie { Id = 16, Title = "Star Wars: Episode I - The Phantom Menace", Category = "Bilim Kurgu", Director = "George Lucas", Description = "İki Jedi şövalyesi, barışçıl bir gezegeni kurtarmak için kaçarken, Güç ile inanılmaz bir bağlantısı olan genç Anakin Skywalker ile tanışırlar.", ImageUrl = "sw1.jpg", IMDBScore = 6.5 },
            new Movie { Id = 17, Title = "Star Wars: Episode II - Attack of the Clones", Category = "Bilim Kurgu", Director = "George Lucas", Description = "Anakin Skywalker, Padmé Amidala'yı korumakla görevlendirilirken yasak bir aşka sürüklenir. Bu sırada galaksi, Klon Savaşları'nın eşiğine gelmiştir.", ImageUrl = "sw2.jpg", IMDBScore = 6.6 },
            new Movie { Id = 18, Title = "Star Wars: Episode III - Revenge of the Sith", Category = "Bilim Kurgu", Director = "George Lucas", Description = "Klon Savaşları sona ererken, Anakin Skywalker karanlık tarafa geçerek Darth Vader'a dönüşür ve Galaktik İmparatorluk yükselişe geçer.", ImageUrl = "sw3.jpg", IMDBScore = 7.6 },
            new Movie { Id = 19, Title = "Star Wars: Episode IV - A New Hope", Category = "Bilim Kurgu", Director = "George Lucas", Description = "Luke Skywalker, bir Jedi ustası, ukala bir pilot ve iki droid ile birleşerek galaksiyi İmparatorluğun dünya yok eden istasyonundan, Ölüm Yıldızı'ndan kurtarmaya çalışır.", ImageUrl = "sw4.jpg", IMDBScore = 8.6 },
            new Movie { Id = 20, Title = "Star Wars: Episode V - The Empire Strikes Back", Category = "Bilim Kurgu", Director = "Irvin Kershner", Description = "İsyancılar İmparatorluk tarafından kovalanırken, Luke Skywalker Jedi Ustası Yoda ile eğitime başlar. Ancak Darth Vader ile yapacağı düello, şok edici bir gerçeği ortaya çıkaracaktır.", ImageUrl = "sw5.jpg", IMDBScore = 8.7 },
            new Movie { Id = 21, Title = "Star Wars: Episode VI - Return of the Jedi", Category = "Bilim Kurgu", Director = "Richard Marquand", Description = "Luke Skywalker, Darth Vader'ı karanlık taraftan döndürmeye çalışırken, İsyancılar ikinci Ölüm Yıldızı'nı yok etmek için son bir saldırı başlatır.", ImageUrl = "sw6.jpg", IMDBScore = 8.3 },

            // --- LORD OF THE RINGS (FANTASTİK) ---
            new Movie { Id = 22, Title = "The Lord of the Rings: The Fellowship of the Ring", Category = "Fantastik", Director = "Peter Jackson", Description = "Genç bir Hobbit olan Frodo, tüm dünyayı tehdit eden Tek Yüzük'ü yok etmekle görevlendirilir. Ona bu yolculukta insanlar, elfler ve cücelerden oluşan bir kardeşlik eşlik eder.", ImageUrl = "lotr1.jpg", IMDBScore = 8.8 },
            new Movie { Id = 23, Title = "The Lord of the Rings: The Two Towers", Category = "Fantastik", Director = "Peter Jackson", Description = "Kardeşlik bozulmuştur. Frodo ve Sam Mordor'a doğru ilerlerken, Aragorn ve diğerleri Saruman'ın ordularına karşı Miğfer Dibi'nde efsanevi bir savunma yapar.", ImageUrl = "lotr2.jpg", IMDBScore = 8.8 },
            new Movie { Id = 24, Title = "The Lord of the Rings: The Return of the King", Category = "Fantastik", Director = "Peter Jackson", Description = "Sauron'un orduları Minas Tirith'e saldırırken, Orta Dünya'nın kaderi Frodo'nun Yüzük'ü Hüküm Dağı'nın ateşine atmasına bağlıdır.", ImageUrl = "lotr3.jpg", IMDBScore = 9.0 },

            // --- THE MATRIX TRILOGY (BİLİM KURGU) ---
            new Movie { Id = 25, Title = "The Matrix", Category = "Bilim Kurgu", Director = "Lana & Lilly Wachowski", Description = "Bir bilgisayar korsanı olan Neo, yaşadığı dünyanın aslında makineler tarafından yaratılmış bir simülasyon olduğunu öğrenir ve insanlığı özgürleştirmek için direnişe katılır.", ImageUrl = "matrix1.jpg", IMDBScore = 8.7 },
            new Movie { Id = 26, Title = "The Matrix Reloaded", Category = "Bilim Kurgu", Director = "Lana & Lilly Wachowski", Description = "Neo, Trinity ve Morpheus, Zion'u makinelerin saldırısından kurtarmak için Matrix'in derinliklerine inerek Kahin ve Anahtarcı'yı bulmaya çalışırlar.", ImageUrl = "matrix2.jpg", IMDBScore = 7.2 },
            new Movie { Id = 27, Title = "The Matrix Revolutions", Category = "Bilim Kurgu", Director = "Lana & Lilly Wachowski", Description = "İnsanlık ve makineler arasındaki savaş nihai sona yaklaşırken, Neo hem gerçek dünyada hem de Matrix'te Smith ile son kez yüzleşmek zorundadır.", ImageUrl = "matrix3.jpg", IMDBScore = 6.7 },

            // --- MARVEL UNIVERSE (AKSİYON) ---
            new Movie { Id = 28, Title = "Iron Man", Category = "Aksiyon", Director = "Jon Favreau", Description = "Milyarder mucit Tony Stark, kaçırıldıktan sonra hayatta kalmak için zırhlı bir kıyafet yapar ve bu teknolojiyi dünyayı korumak için kullanarak Iron Man'e dönüşür.", ImageUrl = "ironman.jpg", IMDBScore = 7.9 },
            new Movie { Id = 29, Title = "The Avengers", Category = "Aksiyon", Director = "Joss Whedon", Description = "Loki ve uzaylı ordusu dünyayı tehdit ettiğinde, Nick Fury en güçlü kahramanları bir araya getirerek S.H.I.E.L.D. bünyesinde Yenilmezler ekibini kurar.", ImageUrl = "avengers1.jpg", IMDBScore = 8.0 },
            new Movie { Id = 30, Title = "Avengers: Infinity War", Category = "Aksiyon", Director = "Russo Brothers", Description = "Thanos, evrenin yarısını yok etmek için Sonsuzluk Taşları'nı toplamaya başlar. Avengers ve Galaksinin Koruyucuları, onu durdurmak için güçlerini birleştirir.", ImageUrl = "infinitywar.jpg", IMDBScore = 8.4 },
            new Movie { Id = 31, Title = "Avengers: Endgame", Category = "Aksiyon", Director = "Russo Brothers", Description = "Thanos'un yıkımından sonra geriye kalan kahramanlar, evrenin düzenini geri getirmek ve kaybettikleri sevdiklerini kurtarmak için zamanda riskli bir yolculuğa çıkarlar.", ImageUrl = "endgame.jpg", IMDBScore = 8.4 },
            new Movie { Id = 32, Title = "Spider-Man 3", Category = "Aksiyon", Director = "Sam Raimi", Description = "Efsanevi Marvel çigzi roman serisine dayanan \"Örümcek Adam 3\"te, Peter Parker (Tobey Maguire) nihayet Mary Jane'e (Kirsten Dunst) duyduğu tutku ile süper kahramanlık görevleri arasındaki dengeyi kurar. Fakat, ufukta belirmeye başlayan bir fırtına vardır. Kostümü bir anda siyaha dönüşen Peter'ın kişiliğe de değişmeye başlar. Örümcek- Adam bu sefer sadece düşmanlarıyla değil içindeki savaşla da mücadele etmelidir.", ImageUrl = "spidermannwh.jpg", IMDBScore = 8.2 },

            // --- ANIMATION CLASSICS (ANİMASYON) ---
            new Movie { Id = 33, Title = "Toy Story", Category = "Animasyon", Director = "John Lasseter", Description = "Andy'nin favori oyuncağı kovboy Woody, yeni gelen uzay korucusu Buzz Işıkyılı'nı kıskanır. Ancak ikili, kendilerini tehlikeli bir maceranın içinde bulup dost olmayı öğrenirler.", ImageUrl = "toystory.jpg", IMDBScore = 8.3 },
            new Movie { Id = 34, Title = "Finding Nemo", Category = "Animasyon", Director = "Andrew Stanton", Description = "Oğlunu kaybeden endişeli bir palyaço balığı olan Marlin, unutkan balık Dory ile birlikte okyanusu aşarak Nemo'yu Sidney'deki bir dişçinin akvaryumundan kurtarmaya çalışır.", ImageUrl = "nemo.jpg", IMDBScore = 8.1 },
            new Movie { Id = 35, Title = "WALL·E", Category = "Animasyon", Director = "Andrew Stanton", Description = "Gelecekte çöp yığınına dönmüş Dünya'da yapayalnız kalan robot WALL·E, gezegene keşif için gelen modern robot EVE'e aşık olur ve onu takip ederek insanlığın kaderini değiştirir.", ImageUrl = "walle.jpg", IMDBScore = 8.4 },
            new Movie { Id = 36, Title = "The Lion King", Category = "Animasyon", Director = "Roger Allers", Description = "Genç aslan prens Simba, babasının ölümünden kendini sorumlu tutarak krallığı terk eder. Ancak geçmişiyle yüzleşmek ve hakkı olan tahtı geri almak için geri dönmek zorundadır.", ImageUrl = "lionking.jpg", IMDBScore = 8.5 },
            new Movie { Id = 37, Title = "Spider-Man: Into the Spider-Verse", Category = "Animasyon", Director = "Peter Ramsey", Description = "Miles Morales, örümcek güçleri kazandıktan sonra, farklı boyutlardan gelen diğer Örümcek-Adamlarla tanışır ve tüm gerçekliği tehdit eden bir tehlikeye karşı birleşirler.", ImageUrl = "spiderverse.jpg", IMDBScore = 8.4 },

            // --- DRAMA & CULT CLASSICS (DRAMA) ---
            new Movie { Id = 38, Title = "The Godfather", Category = "Drama", Director = "Francis Ford Coppola", Description = "Corleone suç ailesinin yaşlanan patriği, imparatorluğunu isteksiz oğluna devrederken, bu süreç aileyi şiddet ve ihanet dolu bir savaşa sürükler.", ImageUrl = "godfather.jpg", IMDBScore = 9.2 },
            new Movie { Id = 39, Title = "The Shawshank Redemption", Category = "Drama", Director = "Frank Darabont", Description = "İşlemediği bir suçtan dolayı ömür boyu hapse mahkum edilen Andy Dufresne, umudunu kaybetmeden hapishane koşullarına direnir ve Red adında bir mahkumla derin bir dostluk kurar.", ImageUrl = "shawshank.jpg", IMDBScore = 9.3 },
            new Movie { Id = 40, Title = "Pulp Fiction", Category = "Drama", Director = "Quentin Tarantino", Description = "İki tetikçi, bir boksör, bir gangsterin karısı ve bir çift soyguncunun yolları, şiddet ve mizah dolu dört farklı hikayede kesişir.", ImageUrl = "pulpfiction.jpg", IMDBScore = 8.9 },
            new Movie { Id = 41, Title = "Fight Club", Category = "Drama", Director = "David Fincher", Description = "Uykusuzluk çeken bir ofis çalışanı, karizmatik sabun satıcısı Tyler Durden ile tanışır. Birlikte kurdukları yeraltı dövüş kulübü, kısa sürede kontrolden çıkan bir anarşist harekete dönüşür.", ImageUrl = "fightclub.jpg", IMDBScore = 8.8 },
            new Movie { Id = 42, Title = "Forrest Gump", Category = "Drama", Director = "Robert Zemeckis", Description = "Düşük IQ'ya sahip ama iyi kalpli Forrest Gump, 20. yüzyılın en önemli tarihi olaylarına tanıklık ederken, tek aşkı Jenny'yi asla unutmaz.", ImageUrl = "forrestgump.jpg", IMDBScore = 8.8 },
            new Movie { Id = 43, Title = "The Truman Show", Category = "Drama", Director = "Peter Weir", Description = "Truman Burbank, tüm hayatının aslında devasa bir stüdyoda çekilen ve tüm dünya tarafından izlenen bir televizyon şovu olduğunu keşfeder ve gerçek dünyayı bulmak için kaçmaya çalışır.", ImageUrl = "truman.jpg", IMDBScore = 8.2 },
            new Movie { Id = 44, Title = "Parasite", Category = "Drama", Director = "Bong Joon Ho", Description = "Yoksul Kim ailesi, zengin Park ailesinin evine sızarak hayatlarını değiştirmeye çalışır. Ancak beklenmedik bir olay, her iki aileyi de geri dönüşü olmayan bir felakete sürükler.", ImageUrl = "parasite.jpg", IMDBScore = 8.5 },

            // --- ANIME SELECTIONS (ANİME) ---
            new Movie { Id = 45, Title = "Chainsaw Man: Reze Arc", Category = "Anime", Director = "Ryu Nakayama", Description = "Denji, Reze adında gizemli bir kızla tanışır ve ona aşık olur. Ancak Reze'nin gerçek kimliği ve niyetleri, Denji'yi testereler ve patlamalarla dolu kanlı bir savaşa sürükleyecektir.", ImageUrl = "reze.jpg", IMDBScore = 9.1 },
            new Movie { Id = 46, Title = "Spirited Away", Category = "Anime", Director = "Hayao Miyazaki", Description = "Ailesiyle birlikte taşınırken gizemli bir dünyaya giren Chihiro, anne ve babasının domuza dönüşmesiyle, onları kurtarmak için ruhların hamamında çalışmak zorunda kalır.", ImageUrl = "spirited.jpg", IMDBScore = 8.6 },
            new Movie { Id = 47, Title = "Your Name", Category = "Anime", Director = "Makoto Shinkai", Description = "Biri Tokyo'da diğeri kırsalda yaşayan iki lise öğrencisi, rüyalarında beden değiştirdiklerini fark ederler. Zaman ve mekanı aşan bu bağ, onları bekleyen felaketi önlemek için tek şanstır.", ImageUrl = "yourname.jpg", IMDBScore = 8.4 },

            // --- HORROR & THRILLER (KORKU) ---
            new Movie { Id = 48, Title = "The Shining", Category = "Korku", Director = "Stanley Kubrick", Description = "Yazar Jack Torrance, kışın kapalı olan izole bir otelin bakımını üstlenir. Ancak otelin karanlık geçmişi ve kötücül ruhları, Jack'i yavaş yavaş deliliğe sürüklerken ailesini tehdit etmeye başlar.", ImageUrl = "shining.jpg", IMDBScore = 8.4 },
            new Movie { Id = 49, Title = "Get Out", Category = "Korku", Director = "Jordan Peele", Description = "Siyahi bir genç olan Chris, beyaz kız arkadaşının ailesiyle tanışmaya gider. Başta her şey normal görünse de, ailenin tuhaf davranışları korkunç bir gerçeği ortaya çıkarır.", ImageUrl = "getout.jpg", IMDBScore = 7.7 },
            new Movie { Id = 50, Title = "Psycho", Category = "Korku", Director = "Alfred Hitchcock", Description = "Patronunun parasını çalıp kaçan bir sekreter, geceyi geçirmek için izbe bir motele sığınır. Ancak oteli işleten Norman Bates ve gizemli annesi, onun sonunu getirecektir.", ImageUrl = "psycho.jpg", IMDBScore = 8.5 }
        };

        // Kategori filtresi uygulandı
        public IActionResult Index(string category)
        {
            var filmler = _movies;

            if (!string.IsNullOrEmpty(category))
            {
                filmler = _movies.Where(x => x.Category == category).ToList();
            }

            return View(filmler);
        }

        // Detay sayfası verisi çekildi
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