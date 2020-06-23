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
})