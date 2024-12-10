namespace pesalupro.Model {
    public class Pessoa {
        public string Nome { get; set; }
        public long Cpf { get; set; }

        public virtual void Apresentar(){
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
        }
        public void Dormir(int horas){
            Console.WriteLine("Deitei, fechei os olhos e dormi por " + horas + " horas");
        }
    }
}