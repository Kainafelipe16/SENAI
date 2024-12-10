namespace banco.Model {
    public class Corrente: Conta {
        public long NumeroConta { get; set; }
        public double Tarifa { get; set; }

    
    public void ImprimirSaldo(){
        Console.WriteLine("O Saldo atual na sua conta é de: " + base.Saldo);
        }
    }
}