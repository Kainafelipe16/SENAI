var tm1 = document.getElementById("tm1");
var tm2 = document.getElementById("tm2");
var tm3 = document.getElementById("tm3");
var tm4 = document.getElementById("tm4");
var tm5 = document.getElementById("tm5");

var mascote1 = "Timão";
var mascote2 = "Verdão";
var mascote3 = "Tricolor";
var mascote4 = "Peixe";

//Estrutura Condicional IF

if (mascote2 == "Verdão") {
    tm1.innerHTML = "Meu time é o Palmeiras";
}

//Estrutura Condicional IF ELSE
if (mascote1 == "Tricolor") {
    tm2.innerHTML = "Meu time é o Corinthians";
}
else {
    tm2.innerHTML = "Mascote não correspondente!";
}

//Estrutura Condicional Ternario
(mascote3 == "Tricolor") ? tm3.innerHTML = "Meu time é o São Paulo" : tm3.innerHTML = "Mascote não correspondente!";

//Estrutura Condicional Encadeada
if (mascote4 == "Timão") {
    tm4.innerHTML = "Meu time é o Corinthians";
}
else if (mascote4 == "Verdão") {
    tm4.innerHTML = "Meu time é o Palmeiras";
}
else if (mascote4 == "Tricolor") {
    tm4.innerHTML = "Meu time é o São Paulo";
}
else if (mascote4 == "Peixe") {
    tm4.innerHTML = "Meu time é o Santos";
}
else {
    tm4.innerHTML = "Mascote não correspondente!";
}

//Estrutura de Decisão
var mascote = "Verdão";

switch (mascote) {
    case "Timão": {tm5.innerHTML = "Meu time é o Corinthians";}
    break;
    case "Verdão": {tm5.innerHTML = "Meu time é o Palmeiras";}
    break;
    case "Tricolor": {tm5.innerHTML.HTML = "Meu time é o São Paulo";}
    break;
    case "Peixe": {tm5;innerHTML = "Meu time é o Santos";}
    break;
    default : {tm5.innerHTMLHTML = "Time não encontrado!";}
}