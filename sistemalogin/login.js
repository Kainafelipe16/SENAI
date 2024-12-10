const mensagem = document.querySelector(".mensagem");
const email = document.getElementById("email");
const senha = document.getElementById("senha");
const formulario = document.getElementById("formulario");

formulario.onsubmit = (evento) => {
    let dados = JSON.parse(localStorage.getItem("dados"));

    dados.forEach((elemento) => {
        if (elemento.email === email.value && elemento.senha === senha.value) {
            evento.preventDefault();
            mensagem.innerHTML = "<p> Logado </p>";
            return true;
        }

        else{
            mensagem.innerHTML = "<p> E-mail ou senha incorretas </p>";
            evento.preventDefault();
        }
    });
}