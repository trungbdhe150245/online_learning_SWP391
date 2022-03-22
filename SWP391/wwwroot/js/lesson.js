let hreflist = document.querySelectorAll('.list-group .list-group-item');
let mainvideo = document.querySelector('.row .col-lg-8 .courses-post video');
let maintitle = document.querySelector('.row .col-lg-8 .courses-post .title');
let mainscript = document.querySelector('.row .col-lg-8 .courses-post .collapse .card');
hreflist.forEach(href => {
    href.onclick = () => {
        hreflist.forEach(vid => vid.classList.remove('active'));
        href.classList.add('active');
        if (href.classList.contains('active')) {
            let src = href.children[2].getAttribute('href');
            mainvideo.src = src;
            let title = href.children[1].innerHTML;
            maintitle.innerHTML = title;
            let script = href.children[3].innerHTML;
            mainscript.innerHTML = script;
        };
    };
});

function scriptToggle() {
    document.getElementById("collapseExample2").classList.remove("show");
}
function noteToggle() {
    document.getElementById("collapseExample").classList.remove("show");
}

document.addEventListener('DOMContentLoaded', function () {
    hreflist[0].classList.add("active");
    document.getElementById("collapseOne0").classList.add("show");

}, false);


