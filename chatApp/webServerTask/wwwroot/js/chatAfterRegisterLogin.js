// this is for the user details


// display nickname in chat after register
var div1 = document.getElementById("userNickname");
if (div1) {
    div1.innerHTML = '&nbsp;&nbsp;' + localStorage.getItem("nickname");
}


var div2 = document.getElementById("user");
if (div2) {
    div2.innerHTML = '&nbsp;&nbsp;' + localStorage.getItem("nick");
}








