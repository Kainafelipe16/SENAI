// See https://aka.ms/new-console-template for more information
using bicicleta.Model;
namespace bicicleta {
    public class Program {
        public static void Main (){
            var bicicleta = new Bicicleta ();
            bicicleta.Marca = "CALOI";
            bicicleta.Modelo = "BMX";
            bicicleta.Aro = 26;

            bicicleta.Apresentar();
        }
    }
}