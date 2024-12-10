//Criando Arrays
let esportes = ["Basquete", "Vôlei", "Futebol"];
let numeroChamada = Array(17, 27, 35, 14);
let cidades = ["Barueri", "Guararapes", "Carapicuiba"];

document.write(esportes + "<br>");
document.write(numeroChamada + "<br>");
document.write(cidades);
document.write("<hr>");

//adicionar no final do Array
esportes.push("Handebol");
numeroChamada.push(16);

document.write("<b> Adicionei do final: </b>" + cidades);
document.write("<hr>");

//retira do final do Array
esportes.pop();
numeroChamada.pop();

document.write("<b> Retirei do final: </b>" + esportes);
document.write("<hr>");

//adiciona do início, quantos quiser, separado por vírgula
esportes.unshift("Tênis");

document.write("<b> Adicionei do início: </b>" + esportes);
document.write("<hr>");

//retira do início, quantos quiser, separado por vírgula
esportes.shift();

document.write("<b> Retirei do início: </b>" + esportes);
document.write("<hr>");

//remover do Array (índice, casa)
esportes.splice(1,2);
document.write("<b> Retirou a partir da posição 1 das duas casas: </b>" + esportes);
document.write("<hr>");

let novasCidades = cidades.slice();
document.write("<b> Copiou completo: </b>" + novasCidades);
document.write("<hr>");

let novoNumeroChamada = numeroChamada.slice(0,2);
document.write("<b> Copiei do índice 0 duas casas: </b>" + novoNumeroChamada);
document.write("<hr>");

//Spread Operation
let novoEsportes = [...esportes, "Futebol Americano", "Peteca"];
document.write("<b> Copiei inteiro e adicionei </b>" + novoEsportes);
