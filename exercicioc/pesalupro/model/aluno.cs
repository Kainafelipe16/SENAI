namespace pesalupro.Model {
    public class Aluno : Pessoa {
        public long Rm { get; set; }
        public override void Apresentar(){
            base.Apresentar();
            Console.WriteLine("Rm: " + Rm);
        }
    }
}