namespace bicicleta2.Model {

public class Bicicleta2 {
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double Aro { get; set; }
    public double Pedaladas { get; set; }

        Bicicleta pedalada = new Bicicleta2 ();

    public void Apresentar (){
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Tamanho do Aro: " + Aro);
        Console.WriteLine("A distância percorrida é de: " + pedalada);
        pedalada.Distancia();
        }

        public class Bicicleta2 {
            public void Distancia (double pedal) {
                return pedal * 1.5;
            }

        }
    }
}
