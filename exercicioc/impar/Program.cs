// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(){
        Console.WriteLine("Digite um número inteiro");
        int numero = int.Parse(Console.ReadLine());

        int controle = 0;
        while(controle <= numero){
            if (eImpar(controle)){
                Console.WriteLine(controle);
            }
            controle = controle + 1;
            }
        }

        public static bool eImpar(int num) {
        bool result = (num%2 != 0) ? true : false;
        return result;
        }
    }