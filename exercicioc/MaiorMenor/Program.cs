// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(){
        Console.WriteLine("Digite sua idade");
        int idade = int.Parse(Console.ReadLine());

        string idadex = (idade <= 18) ? "Menor de Idade" : "Maior de idade";
        Console.WriteLine(idadex);
    }
}
