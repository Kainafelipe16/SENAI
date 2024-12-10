for (let i = 1; i <= 10; i++)
{
    console.log("senai");

if (i > 5)
{
    break;
}
}

var x = 0;
var contagem = 0;
while (x <= 10)
{
    x++;
    if (x % 2 == 0) {
        continue;
    }
    contagem++;
}
console.log(contagem);