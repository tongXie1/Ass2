function imgWrap(clickedBtn) {
    var btns = document.querySelectorAll(".carousel-inner .carousel-item-img");
    var SelectedSrc = clickedBtn.querySelector('img').src;
    var imgView = document.getElementById("imgView");
    btns.forEach(function (btn) {
        btn.className = "carousel-item-img";
    });
    btns.forEach(function (button){
        button.className = "carousel-item-img";
    });
    clickedBtn.className = "carousel-item-img carousel-item-img-blue";
    imgView.src = SelectedSrc;
}
function dixWrap(clickedBtn) {
    var div = document.querySelector('div');
    var divID = document.getElementById(clickedBtn.id+"d");
    var divs = document.querySelectorAll(".info");
    divs.forEach(function (div) {
        div.className = "info Two";
    })
    divID.className = "info One";
}
function Show() {
    const fullText = document.getElementById("full-text").innerText;
    const maxLength = 500;
    let truncatedText = fullText.substring(0, maxLength);
    let remainingText = fullText.substring(maxLength);
    let isExpanded = false;

    document.getElementById("full-text").innerText = truncatedText;

    document.getElementById("show-more").addEventListener("click", function () {
        if (isExpanded) {
            document.getElementById("full-text").innerText = truncatedText;
            document.getElementById("show-more").textContent = "Show More";
        } else {
            document.getElementById("full-text").innerText = fullText;
            document.getElementById("show-more").textContent = "Recover";
        }
        isExpanded = !isExpanded;
    });
}
