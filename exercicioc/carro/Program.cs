// See https://aka.ms/new-console-template for more information
using carro.Model;
namespace carro{
    public class Program {
        public static void Main(){
            var carro = new Carro();
            //Instaciamento do objeto de uma classe
            carro.Placa = "AE3F998";
            carro.Cor = "Vermelho";
            carro.Modelo = "X6";
            carro.Marca = "Mercedez";
            carro.Ano = 2012;
            carro.Chassi = "awgagjes";
            carro.Litragem = 1.6;
            carro.Combustivel = "Etanol";

            carro.ApresentarDoc();
        }
    }
}