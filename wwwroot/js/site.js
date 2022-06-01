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

//добавление ФОТО С УСТРОЙСТВА
const fileUploader = document.getElementById('file-uploader');

fileUploader.addEventListener('change', (event) => {
    const files = event.target.files;
    console.log('files', files);

    const feedback = document.getElementById('feedback');
    feedback.innerHTML = msg;
});