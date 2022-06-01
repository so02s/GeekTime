// const { Callbacks } = require("jquery");

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
console.log("1112");

//добавление ФОТО С УСТРОЙСТВА
const fileUploader = document.getElementById('file-uploader');

File.prototype.convertToBase64 = function (callback) {

    
}

function createImage(imageFile, callback) {
    const image = document.createElement('img');
    image.onload = () => callback(image);
    image.setAttribute('src', imageFile);
}
function convertImage(image) {
    const canvas = drawImageToCanvas(image);
    const ctx = canvas.getContext('2d');

    let result = [];
    for (let y = 0; y < canvas.height; y++) {
        result.push([]);
        for (let x = 0; x < canvas.width; x++) {
            let data = ctx.getImageData(x, y, 1, 1).data;
            result[y].push(data[0]);
            result[y].push(data[1]);
            result[y].push(data[2]);
        }
    }
    const arrayCode = `
    #define IMAGE_WIDTH ${canvas.width}
    #define IMAGE_HEIGHT ${canvas.height}
    #define BYTES_PER_PIXEL 3
    uint8_t imageData[IMAGE_HEIGHT][IMAGE_WIDTH * BYTES_PER_PIXEL] = ${convertArray(result)};
  `;
    document.getElementById('result').innerHTML = arrayCode;
}

function drawImageToCanvas(image) {
    const canvas = document.createElement('canvas');
    canvas.width = image.width;
    canvas.height = image.height;
    canvas.getContext('2d').drawImage(image, 0, 0, image.width, image.height);
    return canvas;
}

function convertArray(array) {
    return JSON.stringify(array).replace(/\[/g, '{').replace(/\]/g, '}');
}

fileUploader.addEventListener('change', (event) => {
    const feedback = document.getElementById('feedback');
    const msg = files[0].name;
    feedback.innerHTML = msg;
});
