const dragItens = document.querySelectorAll(".drag")
const dropItens = document.querySelectorAll(".dropitem");

dragItens.forEach (
    (item) => {
        item.addEventListener("dragstart", pegarItem);
    }
)

dropItens.forEach (
    (item) => {
        item.addEventListener("dragover", emCima);
        item.addEventListener("dragleave", sairCima);
        item.addEventListener("drop", soltar);
    }
)

function soltar (evento){
    evento.preventDefault();
    p = document.createElement("p");
    p.className = "drag"
    p.innerText = evento.dataTransfer.getData("text")
    this.appendChild(p);
}

function pegarItem(evento){
    evento.dataTransfer.setData("text", evento.target.innerText);
    setTimeout(() => {
        this.className = "invisible";
    }, 0)
}

function sairCima(evento){
    evento.preventDefault();
    this.className = "dropitem";
}

function emCima(evento){
    evento.preventDefault();
    this.className += " enter";
}