var demo = document.getElementById('demo');
var one = document.getElementById('one');
var two = document.getElementById('two');

two.innerHTML = one.innerHTML;

function marquee() {
    if (demo.scrollLeft >= (demo.scrollWidth - demo.clientWidth)) {
        demo.scrollLeft = 0;
    } else {
        demo.scrollLeft += 1;
    }
}

var timer = setInterval(marquee, 10);
