namespace nota.Model{
    public class NotaFiscal{
        public long Numero {get; set;}
        public long CNPJ {get; set;}
        public DateTime DataEmissao {get; set;}
        public double ValorTotal {get; set;}
        public List<Item> Items = new List<Item>();
        public NotaFiscal(long numero, long cNPJ, DateTime dataEmissao){
            this.Numero = numero;
            this.CNPJ = cNPJ;
            this.DataEmissao = dataEmissao;
        }
        public void ImprimirNota(){
            Console.WriteLine("Nota Numero "+ Numero);
            Console.WriteLine("CNPJ "+ CNPJ);
            Console.WriteLine("Data de Emissão "+ DataEmissao);
            foreach(Item i in Items){
                ValorTotal = ValorTotal + i.ValorUnitario;
            }
            Console.WriteLine("Valor Total: "+ ValorTotal);
            foreach(Item i in Items){
                Console.WriteLine("Codigo: "+ i.Codigo);
            }
        }
    }
}
