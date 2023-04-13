$(document).ready(function () {
    $('#carouselExampleIndicators').carousel({
        interval: 4500
    });
});

$(function () {
    $('.fiche').on('click', function () {
        $(this).width(1000);
    });
});