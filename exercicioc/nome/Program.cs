// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(){
        string[] nomes = new string[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um nome: ");
            nomes[i] = Console.ReadLine();
        }

        Array.Sort(nomes);

        foreach (string n in nomes) {
            Console.WriteLine(n);
        }
    }
}
