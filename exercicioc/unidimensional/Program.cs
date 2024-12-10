// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(){
        int[] numeros; // não consigo armazenar um espaço no computador
        numeros = new int[3] { 1, 2, 3}; // a marcação sempre começa a partir do zero
        
        int[] numeros2 = new int[3];
        numeros2 [0] = 4;
        numeros2 [0] = 5;
        numeros2 [0] = 6;

        for (int i = 0; i < 3; i++) // i++ é a mesma coisa que (i = i + 1)
        {
            Console.WriteLine ("O número do índice " +i+ " é igual a: " + numeros [i]);
        }

        foreach (int i in numeros2) {
            Console.WriteLine (n);
        }
    }
}
