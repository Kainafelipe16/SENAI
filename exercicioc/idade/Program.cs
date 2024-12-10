// See https://aka.ms/new-console-template for more information
class Program {

    public static void Main(){
        Console.WriteLine("Digite sua idade");
        float idade = float.Parse(Console.ReadLine());
        idade = idade + 10;

        if (idade <= 12) {
            Console.WriteLine("Você é uma criança!");
        }

        else if (idade <= 18) {
            Console.WriteLine("Você é um adolescente!");
        }

        else if (idade >= 18) {
            Console.WriteLine("Você é um adulto!");
        }

        else {
            Console.WriteLine("Você é um idoso!");
        }
    }
}
