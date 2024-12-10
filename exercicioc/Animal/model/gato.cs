namespace animal.Model {
    public class Gato : Animal {
        public string Nome { get; set; }
        public override void EmitirSom(){
            Console.WriteLine("Miau");
        }
    }
}