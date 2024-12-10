let selecionarPorTag = document.querySelector("h1");

//mostra a primeira tag que encontrar
selecionarPorTag.textContent = "Novo texto 1";

let selecionarTodasAsTags = document.querySelectorAll("p");

//como tem mais de um ele se torna um vetor
document.write(selecionarTodasAsTags[0].textContent);
document.write(selecionarTodasAsTags[1].textContent);

//selecionar por Id
let selecionarPorId = document.getElementById("txt2");
selecionarPorId.textContent = "Novo texto 2";

//selecionar pelo nome da classe
let selecionarPorNomeClasse = document.getElementsByClassName("Subtitulo");
selecionarPorNomeClasse[0].textContent = "Novo parágrafo";

let porTag = document.getElementsByTagName("h2");
porTag[0].textContent = "Novo parágrafo 3";