var diaSemana;
var msg;
diaSemana = 3;
switch (diaSemana)
{
    case 1:
        msg="Hoje é: Domingo";
    break;
    case 2:
        msg="Hoje é: Segunda-Feira";
    break;
    case 3:
        msg="Hoje é: Terça-Feira";
    break;
    case 4:
        msg="Hoje é: Quarta-Feira";
    break;
    case 5:
        msg="Hoje é: Quinta-Feitra";
    break;
    case 6:
        msg="Hoje é: Sexta-Feira";
    break;
    case 7:
        msg="Hoje é: Sábado";

        default:
        msg="Esse dia não existe";
}
console.log(msg);