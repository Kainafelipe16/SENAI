// See https://aka.ms/new-console-template for more information
using animal.Model;
namespace animal.Model{
    public class Program {
        public static void Main() {
            var cachorro = new Cachorro();
            cachorro.EmitirSom();
            cachorro.ExecutarComando("deitar", "rolar");

            var gato = new Gato();
            gato.EmitirSom();                              

        }
    }
}