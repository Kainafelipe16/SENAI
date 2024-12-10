//busca botões
const btnAbrir = document.querySelector("#iopen");
const btnFechar = document.querySelector("#iclose");
var modal = document.getElementById("modal");

btnAbrir.addEventListener("click", () => {

    modal.style.display = "block";
});

btnFechar.addEventListener("click", ()=> {
    modal.style.display = "none";
})