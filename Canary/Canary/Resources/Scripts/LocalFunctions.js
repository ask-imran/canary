$('ul.nav').find('a').click(function () {
    var $href = $(this).attr('href');
    var $anchor = $('#about').offset();
    window.scrollTo($anchor.left, $anchor.top);
    return false;
});