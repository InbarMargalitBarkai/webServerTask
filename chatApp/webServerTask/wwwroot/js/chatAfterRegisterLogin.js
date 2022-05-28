// this is for the user details


// display image
var bannerImg = document.getElementById("image");
if (bannerImg) {
    var image = document.createElement("img");
    image.id = "image";
    image.src = localStorage.getItem("photo");
    bannerImg.appendChild(image);
}

// display nickname
var div = document.getElementById("user");
if (div) {
    div.innerHTML = localStorage.getItem("name");
}








