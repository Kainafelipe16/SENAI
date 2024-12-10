// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(){
        Console.WriteLine("Digite o primeiro número inteiro");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número interiro");
        int num2 = int.Parse(Console.ReadLine());
    }

    string resultado = (num1 == num2) ? "Iguais" : "Diferentes";
    Console.WriteLine(resultado);
}