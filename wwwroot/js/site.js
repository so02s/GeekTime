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
    // Клик по кнопке открывает меню, повторный клик закрывает  
    $('.pushmenu').click(function () {
        $('.pushmenu').toggleClass("open");
        $('.sidebar').toggleClass("show");
        $('.hidden-overley').toggleClass("show");
        $('body').toggleClass("sidebar-opened")
    });

    // Когда панель открыта, клик по области вне панели закрывает ее
    $('.hidden-overley').click(function(){
        $(this).toggleClass("show");
      $('.sidebar').toggleClass("show");
      $('.pushmenu').toggleClass("open");
      $('body').toggleClass("sidebar-opened")
    });

    // Меняем активность пункта меню по клику
    $('.sidebar ul li').click(function(){
        $(this).addClass("current-menu-item").siblings().removeClass("current-menu-item");
    });

    // Для анимации поворота каретки
    $('.menu-parent-item a:first-child').click(function(){
        $(this).siblings().toggleClass("show");
        $(this).find("i").toggleClass("rotate");
       });
});