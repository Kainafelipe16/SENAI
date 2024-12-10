namespace animal.Model {

    public class Cachorro : Animal {
    public string Nome { get; set; }
    public override void EmitirSom(){
        Console.WriteLine("AuAu");
        }

        public void ExecutarComando(string cmd){
            Console.WriteLine("Executei comando: " + cmd);
        }

        public void ExecutarComando(string cmd1, string cmd2) {
            Console.WriteLine("Executei comando: " + cmd1 + " E depois executei comando: " + cmd2);
        }
    }
}