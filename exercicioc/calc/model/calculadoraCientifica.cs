using System.Dynamic;
using System.Text.RegularExpressions;
using calculadora.Interface;
namespace calculadora.Model
{

    public class CalculadoraCientifica : ICalc
    {

        public void Adicao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Cientifica de Adição " + (valor1 + valor2));
        }
        public void Subtracao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Cientifica de Subtração " + (valor1 - valor2));
        }
        public void Multiplicacao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Cientifica de Multiplicação " + (valor1 * valor2));
        }
        public void Divisao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Cientifica de Divisão " + (valor1 / valor2));
        }

        public void Potencia(double valor1, double valor2)
        {
            Console.WriteLine("Resultado da Cientifica de Potencia " + (Math.Pow(valor1, valor2)));
        }

    }
}