namespace carro.Model {
    public class Carro{
        public string Placa { get; set; }
        public string Cor  { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Chassi { get; set; }
        public double Litragem { get; set; }
        public string Combustivel { get; set; }

        Motor motor = new Motor();

        //Métodos
        public void ApresentarDoc (){
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Chassi: " + Chassi);
            motor.Consumir(Litragem, Combustivel);
        }

            //Classe interna

            public class Motor {
                
                public void Consumir (double lit, string Combustivel) {
                    if (Combustivel == "Etanol") {
                        if(lit == 1.6){
                            Console.WriteLine("10 km por litro");
                        }
                        else {
                            Console.WriteLine("8 km por litro");
                        }
                    }
                        else {
                        if(lit == 1.6){
                            Console.WriteLine("18 km por litro");
                        }
                        else {
                            Console.WriteLine("15 km por litro");
                        }
                }
            }
        }
    }
}