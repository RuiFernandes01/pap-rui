$(document).ready(function () {

    $('.owl-carousel').owlCarousel({
        autoplay: true,
        autoplayTimeout: 4000,
        margin: 10,
        center: true,
        loop: true,
        nav: true,
        navText: ["<span class='icon icon-arrow-left7'></span>", "<span class='icon icon-arrow-right7'></span>"],
        items: 1,

    });

    $('.header-link').click(function (e) {
        e.preventDefault();
        var target = $(this).data('target');
        $('html, body').animate({
            scrollTop: $("#" + target).offset().top
        }, 600);
    })


})