const botao1 = document.getElementById("btn1");
const botao2 = document.getElementById("btn2");
const tela = document.querySelector(".container");

botao1.addEventListener ("click", () => {
    tela.classList.add ("dark");
    tela.classList.remove ("light");
});

botao2.addEventListener ("click", () => {
    tela.classList.add ("light");
    tela.classList.remove ("dark");
});