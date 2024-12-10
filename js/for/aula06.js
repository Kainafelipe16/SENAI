
//incrementar
for (let i = 0; i <= 10; i++) {
    document.write(i + ",");
}

//apenas pra pular a linha
document.write("br")

//decrementar
for (let i = 10; i >= 1; i--) {
    document.write(i + ",");
}

//apenas para organizar
document.write("<p>Percorrendo o Foreach</p>")

let esportes = ["Volêi", "Basquete", "Futebol"];

//percorrendo o array
for(let i = 0; i < esportes.lenght; i++) {
    document.write(`Esportes: ${esportes[i]} <br>`)
}

//apenas pra organizar
document.write("<p>Método foreach</p>")

//usando o método forEach do Array
//Recebe uma função como parâmetro
cidades = ["Guararapes", "Araçatuba", "Andradina"]
cidades.forEach( (cidade, i, array) => {
    document.write(`Cidade: ${cidade}, índice ${i} Array: ${array} <br>`)
});

//apenas pra organizar
document.write("<p>While</p>")

//while
let carros = ["BWM", "Bentley", "Jaguar", "Ferrari"];
let contador = 0;

while (contador < carros.length) {
    document.write(contador + carros[contador] + "<br>")
    contador++; //incremento para sair do laço
}

//apenas pra organizar
document.write("<p> Do While </p>")

//do while
let contador2 = 0;

do {
    document.write(carros[contador2] + "<br>")
    contador2++; //
}
while (contador2 < carros.length);