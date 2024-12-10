namespace bicicleta.Model {

public class Bicicleta {
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double Aro { get; set; }

    public void Apresentar (){
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Tamanho do Aro: " + Aro);
        }
    }
}
