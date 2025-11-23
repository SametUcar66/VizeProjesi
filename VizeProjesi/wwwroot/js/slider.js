
document.addEventListener("DOMContentLoaded", function () {

    // slider ayarları tanımlandı
    var swiper = new Swiper(".mySwiper", {
        slidesPerView: 1,     
        spaceBetween: 20,     
        loop: true,          

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

        breakpoints: {
            640: { slidesPerView: 2 }, 
            1024: { slidesPerView: 4 }
        }
    });
});