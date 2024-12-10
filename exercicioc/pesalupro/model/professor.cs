namespace pesalupro.Model {
    public class Professor : Pessoa {
        public long Salario { get; set; }
        public override void Apresentar(){
            base.Apresentar();
            Console.WriteLine("O salario do professor é de: R$ " + Salario);
        }
    }
}
