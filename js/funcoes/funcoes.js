
//função sem retorno e sem parâmetros
function menssage () {
    document.write("Olá Mundo! <br>");
}

//função com retorno e sem parâmetros
function msgRetorno () {
    return "Olá mundo, com retorno! <br>";
}

//chamada das funções
menssage();
document.write(msgRetorno());

let x = 5;
let y = 10;

//função sem retorno com parâmetros
function somar (numero1, numero2) {
    document.write("A soma é: " + (numero1 + numero2));
}

somar (x,y);

//função com retorno e com parâmetros
function somaRetorno (numero1, numero2) {
    return "<br> A soma com retorno é: " + (numero1 + numero2);
}

document.write(somaRetorno(x,y));

//função anônima - não tem nome
let anonima = function () {
    document.write("<p> Sou uma Função Anônima </p>");
}

anonima();

//Arrow Function
//Não tem nome, não tem a palavra reservada function
//Se tem apenas uma ação, não precisa das {}

let funcaodeflecha = () => document.write("Uma função de flecha!");

funcaodeflecha();