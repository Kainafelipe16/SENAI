localStorage.setItem("nome", "Kainã");

let sobrenome = "Coelho";

localStorage.setItem("sobrenome", sobrenome);
alert(localStorage.getItem("nome"));
alert(localStorage.getItem("sobrenome"));

localStorage.removeItem("nome");
alert(localStorage.getItem("nome"));

localStorage.removeItem("sobrenome");
alert(localStorage.getItem("sobrenome"));
