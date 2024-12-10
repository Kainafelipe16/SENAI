// See https://aka.ms/new-console-template for more information
using soma23.Model;
namespace soma23.Model {
    public class Program {
        public static void Main() {
            var calcular = new Calcular();
            calcular.Soma(1,2);
            calcular.Soma(1,2,3);
        }
    }
}
