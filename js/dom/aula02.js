let titulo = document.querySelector("#titulo");
//outro modo de mudar HTML0
titulo.innerHTML = "Coloquei o novo título";

let imagem = document.querySelector("#foto");
imagem.setAttribute("src", "https://picsum.photos/id/1/200/200");
//imagem.setAttribute ("width", "400");

//mudar css - seleção do elemento + style + o que quer mudar
titulo.style.color="red";

//Nome composto trocar - por próxima letra em maiúscula
titulo.style.backgroundColor = "black";

//Setar classe do CSS
let container = document.querySelector(".container");
container.setAttribute("class", "amarelo");

// //posso remover tributo
//container.removeAttribute("class");