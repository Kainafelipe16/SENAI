// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main() {
        string[] nomealuno = new string[3];
        float[][] notas = new float[3][];

        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Digite seu nome: ");
            nomealuno[i] = Console.ReadLine();
            notas[i] = new float[2];
            Console.WriteLine("Digite sua 1° nota");
            notas[i][0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 2° nota");
            notas[i][1] = float.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 3;i++) {
            Console.WriteLine("A média do " + nomealuno[i] + " é de: " + (notas[i][0] + notas[i][1])/2);
        }
    }
}
