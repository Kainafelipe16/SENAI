function carregarPagina() {
    window.alert("Página Carregada!");
}

function passeiMouse() {
    window.aleert("Passei o mouse em cima!");
}

function eventoClique() {
    window.alert("Evento pelo HTML");
}

function noFoco () {
    console.log("Estou no Foco!");
}

function teclou () {
    window.alert("Fui Teclado!");
}

//por conta
const botao = document.querySelector("#btn2");

botao.addEventListener("click", ()=> {
    window.alert("Evento por escuta!");
})

//por escuta
const botao3 = document.querySelector("#brn3");

botao3.onclick = () => {
    botao3.textContent = "Já fui clicado";
}