//проезжание вниз до нужного блока для вкладки интерьер
$('.flowing-scroll').on('click', function () {
    var el = $(this);
    var dest = el.attr('href'); // получаем направление
    if (dest !== undefined && dest !== '') { // проверяем существование
        $('html').animate({
            scrollTop: $(dest).offset().top // прокручиваем страницу к требуемому элементу
        }, '20' // скорость прокрутки
        );
    }
    return false;
});

//меню
$(document).ready(function () {
    $('.menu-burger__header').click(function () {
        $('.menu-burger__header').toggleClass('open-menu');
    });
});