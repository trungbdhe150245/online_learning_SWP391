let hreflist = document.querySelectorAll('.list-group .list-group-item');
let mainvideo = document.querySelector('.row .col-md-8 video');
let maintitle = document.querySelector('.row .col-md-8 .title');

hreflist.forEach(href => {
    href.onclick = () => {
        hreflist.forEach(vid => vid.classList.remove('active'));
        href.classList.add('active');
        if (href.classList.contains('active')) {
            let src = href.children[2].getAttribute('href');
            mainvideo.src = src;
            let title = href.children[1].innerHTML;
            maintitle.innerHTML = title;
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


function download(file, text) {
    //creating an invisible element
    var element = document.createElement('a');
    element.setAttribute('href', 'data:text/html;charset=utf-8,' + encodeURIComponent(text));
    element.setAttribute('download', file);
    document.body.appendChild(element);
    element.click();
    document.body.removeChild(element);
}

var btn_mop = document.getElementsByClassName("btn_mop");
for (var btn of btn_mop) {
    btn.addEventListener("click", function () {
        var text = this.previousSibling.previousSibling
        var filename = "Note.txt";
        download(filename, text.value)
    });
}