// See https://aka.ms/new-console-template for more information
using aluno.Model;
namespace aluno{
    public class Program
    {
        public static void Main(){
           // var pessoa = new Pessoa();
           // pessoa.setCpf(24456198826);
           // pessoa.Nome = "Kainã";
           // pessoa.Sexo = "Masculino";
           // pessoa.ImprimeDados();

            var aluno = new Aluno();
            aluno.Nome = "Kainã";
            aluno.setCpf(123);
            aluno.Sexo = "Masculino";
            aluno.Rm = 1234;
            aluno.ImprimeDados();
        }
    }
}