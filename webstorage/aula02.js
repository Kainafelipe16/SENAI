const pessoa = {
    nome : "Kainã",
    sobrenome : "Felipe",
    email : "kain.filipe@gmail.com"
}

localStorage.setItem("personagens", JSON.stringify(pessoa));

const objpessoa = JSON.parse(localStorage.getItem("personagens"));
alert(objpessoa.nome);