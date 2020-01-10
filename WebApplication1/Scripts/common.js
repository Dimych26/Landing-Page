window.addEventListener("scroll", function () {
    var sc = window.pageYOffset;
    var elem = document.getElementsByClassName(".raz");
    if (sc >= 200) {
        $(".raz").each(function (i) {
            $(this).delay((i++) * 800).fadeTo(2000, 1).is();
        })
    }
});
window.addEventListener("scroll", function () {
    var sc = window.pageYOffset;
    var elem = document.getElementsByClassName(".dva");
    if (sc >= 1200) {
        $(".dva").each(function (i) {
            $(this).delay((i++) * 800).fadeTo(2000, 1).is();
        })
    }
});
window.addEventListener("scroll", function () {
    var sc = window.pageYOffset;
    var elem = document.getElementsByClassName(".pun1");
    if (sc >= 1200) {
        $(".pun1").each(function (i) {
            $(this).delay((i++) * 800).fadeTo(2000, 1).is();
        })
    }
});
$(document).ready(function () {

    $('.basket').click(function () {
        $(this).parent().children('.centr').show('normal');
        return false;

    });
    $('.basket').click(function () {
        $(this).parent().children('div#gray').show('normal');
        return false;

    });
    $('.basket').click(function () {
        $('.nestoit').show('normal');
        return false;

    });
    $('.nestoit').click(function () {
        $(this).parent().children('.centr').hide('normal');
        return false;

    });
    $('.nestoit').click(function () {
        $(this).parent().children('.nestoit').hide('normal');
        return false;

    });
});