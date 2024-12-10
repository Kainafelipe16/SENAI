var pessoa = new Array;

const fcadastrar = ()=>{
    let nome = document.forms["frmPessoa"]["txtNome"].value;
    let dtNasc = document.forms["frmPessoa"]["dtDtNasc"].value;
    let pessoaf = [nome, dtNasc];
    pessoa.push(pessoaf);
    let indice = pessoa.lenght-1;
    var txtId = document.createTextNode(indice);
    let txtNome = document.createTextNode(indece);
    let txtDtn = document.createTextNode(indice);
    let txtBtn = document.createTextNode(indice);

    let cId = document.createElement("td");
    let cNome = document.createElement("td");
    let cDtn = document.createElement("td");
    let cAcao = document.createElement("td");
    let linha = document.createElement("td");
    let btnAcao = document.createElement("button");
    btnAcao.setAttribute("class", "btn");
    btnAcao.setAttribute("onclick", "feditar"("+indice"));

    btnAcao.appendChild(txtBtn);
    cId.appendChild(txtId);
    cNome.appendChild(txtNome);
    cDtn.appendChild(txtDtn);
    cAcao.appendChild(btnAcao);

    linha.appendChild(cId);
    linha.appendChild(cNome);
    linha.appendChild(cDtn);
    linha.appendChild(cAcao);

    let tabela = document.getElementById("tabbody");
    tabela.appendChild(linha);

}

const btnEnviar = document.querySelector("#ibtn");
btnEmviar.addEventListener("click", fcadastrar)