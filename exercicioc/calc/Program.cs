// See https://aka.ms/new-console-template for more information
using calculadora.Model;
namespace calculadora
{
    public class Program
    {
        public static void Main()
        {
            var Normal = new CalculadoraNomal();
            Normal.Adicao(12, 11);
            Normal.Subtracao(23, 3);
            Normal.Multiplicacao(3, 5);
            Normal.Divisao(20, 4);

            var Cienc = new CalculadoraCientifica();
            Cienc.Adicao(12, 11);
            Cienc.Subtracao(23, 3);
            Cienc.Multiplicacao(3, 5);
            Cienc.Divisao(20, 4);
            Cienc.Potencia(2, 4);
        }
    }
}
