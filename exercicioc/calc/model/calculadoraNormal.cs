using System.Dynamic;
using calculadora.Interface;
namespace calculadora.Model
{
    public class CalculadoraNomal : ICalc
    {

        public void Adicao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Normal de Adição " + (valor1 + valor2));
        }
        public void Subtracao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Normal de Subtração " + (valor1 - valor2));
        }
        public void Multiplicacao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Normal de Multiplicação " + (valor1 * valor2));
        }
        public void Divisao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Normal de Divisão " + (valor1 / valor2));
        }

    }
}