const today = new Date();
const dtnasc = new Date("2006-07-16");

console.log(today.toDateString());
console.log(today.toISOString());

console.log(today.getDate());

ano1 = today.getFullYear();
ano2 = dtnasc.getFullYear();

console.log(ano1-ano2);