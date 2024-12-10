var aluno = {
    nome : "Kainã Felipe",
    idade : 16,
    nota : 8.5,
    matriculado : true
}

let esportes = {
    tipo : [],
    jogadores : []
}

const menu = {
    inicial : ["Home", "Login", "Contato", "Hamburguer"],
    login : ["Home", "Contato", "Hamburguer"]
}

console.log(aluno.nome);

//modificar valores do objeto
aluno.nome = "Figueredo dos Santos";

esportes.tipo = ['Basquete'];

//quando o array já ta instanciado usar o spread operator
esportes.tipo = [...esportes.tipo, 'Vôlei']
console.log(esportes);