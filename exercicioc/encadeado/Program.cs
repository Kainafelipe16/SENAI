// See https://aka.ms/new-console-template for more information

class Program{

    public static void Main(){
            Console.WriteLine("Digite sua temperatura");
            float temp = float.Parse(Console.ReadLine());

            if(temp < 35.5){
            Console.WriteLine("Hiportemia! Aquece o corpo aí, tiw!");
            }

            else if (temp < 37.6){
                Console.WriteLine("Tá normal, lek!!");
            }

            else {
                Console.WriteLine("Tá pegano fogo, bixo!!");
            }
    }
}
