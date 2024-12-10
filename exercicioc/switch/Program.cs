// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(){
        Console.WriteLine("Digite um número de 1 a 7");
        int diaSemana = int.Parse(Console.ReadLine());

        switch (diaSemana) {
            case 1: Console.WriteLine("Domingo"); break;
            case 2: Console.WriteLine("Segunda"); break;
            case 3: Console.WriteLine("Terça"); break;
            case 4: Console.WriteLine("Quarta"); break;
            case 5: Console.WriteLine("Quinta"); break;
            case 6: Console.WriteLine("Sexta"); break;
            case 7: Console.WriteLine("Sabádo"); break;
            default: Console.WriteLine("Número digitado invalido"); break;
        }
    }
}
