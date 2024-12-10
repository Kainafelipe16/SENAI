// See https://aka.ms/new-console-template for more information

using System;
class Program {
    public static void Main(){
        Console.WriteLine("Digite sua altura");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu peso");
        float peso = float.Parse(Console.ReadLine());

        if (peso/Math.Pow(altura,2) < 17) {
            Console.WriteLine("Tá magro demais! Cuidado pra não morrer!");
        }

        else if (peso/Math.Pow(altura,2) <= 18.49) {
            Console.WriteLine("Tá magro, hein!");
        }

        else if (peso/Math.Pow(altura,2) <= 24.99) {
            Console.WriteLine("Tá normal, pô!");
        }

        else if (peso/Math.Pow(altura,2) <= 29.99) {
            Console.WriteLine("Tá começando a ficar gordin!");
        }

        else if (peso/Math.Pow(altura,2) <= 34.99) {
            Console.WriteLine("Obeso I");
        }

        else if (peso/Math.Pow(altura,2) <= 39.99) {
            Console.WriteLine("Obeso II");
        }

        else if (peso/Math.Pow(altura,2) > 40) {
            Console.WriteLine("Obeso III");
        }

        else {
            Console.WriteLine("O número digitado é invalido");
        }
    }
}
