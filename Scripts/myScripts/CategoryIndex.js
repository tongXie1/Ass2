$(document).ready(function () {
    $(".product-item").on("click", function () {
        $(".product-item").removeClass("active");
        $(this).addClass("active");
    });
});