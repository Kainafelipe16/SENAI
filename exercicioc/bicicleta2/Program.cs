// See https://aka.ms/new-console-template for more information
using bicicleta2.Model;
namespace bicicleta2 {
    public class Program {
        public static void Main (){
            var bicicleta2 = new Bicicleta2 ();
            bicicleta2.Marca = "MERCEDEZ";
            bicicleta2.Modelo = "BMX";
            bicicleta2.Aro = 26;

            bicicleta2.Apresentar();
        }
    }
}