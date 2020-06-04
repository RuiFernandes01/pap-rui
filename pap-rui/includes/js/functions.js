$(document).ready(function () {
    $('.owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        nav: true,
        items: 1,
    })

    $('.header-link').click(function (e) {
        e.preventDefault();
        var target = $(this).data('target');
        $('html, body').animate({
            scrollTop: $("#" + target).offset().top
        }, 600);
    })

    var map = L.map('mapid').setView([37.138957, -8.021973], 14);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    L.marker([37.138957, -8.021973]).addTo(map)
        .bindPopup('Academia Iluminarte')
        .openPopup();
})