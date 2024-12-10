function update() {
const elem = document.getElementById("example");
const rect = elem.getBoundingClientRect();
const paragrafos = document.querySelectorAll("p")

paragrafos[0] = "x: " + rect.x;
paragrafos[1] = "y: " + rect.y;
paragrafos[2] = "width: " + rect.width;
paragrafos[3] = "height: " + rect.height;
paragrafos[4] = "top: " + rect.top;
paragrafos[5] = "right: " + rect.right;
paragrafos[6] = "bottom: " + rect.bottom;
paragrafos[7] = "left: " + rect.left;
}

document.addEventListener("scroll", update);