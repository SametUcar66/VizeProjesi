// sayfa yüklendiğinde çalışması sağlandı
document.addEventListener("DOMContentLoaded", function () {

    // slider ayarları tanımlandı
    var swiper = new Swiper(".mySwiper", {
        slidesPerView: 1,      // mobilde 1 tane gösterildi
        spaceBetween: 20,      // boşluk bırakıldı
        loop: true,            // sonsuz döngü açıldı

        // ok tuşları tanımlandı
        navigation: {
            nextEl: ".swiper-button-next",
            prevEl: ".swiper-button-prev",
        },

        // alt noktalar tanımlandı
        pagination: {
            el: ".swiper-pagination",
            clickable: true,
        },

        // ekran boyutuna göre ayar yapıldı
        breakpoints: {
            640: { slidesPerView: 2 }, // tablette 2
            1024: { slidesPerView: 4 } // pc'de 4
        }
    });
});