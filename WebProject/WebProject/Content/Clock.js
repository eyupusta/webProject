function startTime() {
    var today = new Date();
    var h = today.getHours();
    var m = today.getMinutes();
    var d = today.getDate();
    var mo = today.getMonth() + 1;
    var y = today.getFullYear();
    h = checkTime(h);
    m = checkTime(m);
    d = checkTime(d);
    mo = checkTime(mo);
    document.getElementById('clock').innerHTML = d + "/" + mo + "/" + y + "<br/>" +
        h + ":" + m;
    var t = setTimeout(startTime, 500);
}
function checkTime(i) {
    if (i < 10) { i = "0" + i };  // add zero in front of numbers < 10
    return i;
}