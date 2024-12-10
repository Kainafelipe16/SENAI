// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(){
        Console.WriteLine("Insira uma temperatura em °C");
        float temp = float.Parse(Console.ReadLine());
        Console.WriteLine("A temperatura atual " + temp + "°C é igual a " + Form (temp) + "°F");
    }
    public static double Form(float temp) {
        return temp*1.8 + 32;
    }
}
