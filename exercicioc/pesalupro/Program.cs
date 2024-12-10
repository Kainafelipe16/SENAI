// See https://aka.ms/new-console-template for more information
using pesalupro.Model;
namespace pesalupro {
    public class Program {
        public static void Main() {
            var pessoa = new Pessoa();
            pessoa.Nome = "Josisnelson da Silva";
            pessoa.Cpf = 24456198826;
            pessoa.Apresentar();

            var aluno = new Aluno();
            aluno.Nome = "Josisnelson Aluno";
            aluno.Cpf = 24456198826;
            aluno.Rm = 3741;
            aluno.Apresentar();
            aluno.Dormir(8);

            var professor = new Professor();
            professor.Salario = 1200;
            professor.Nome = "Heitorzin";
            professor.Cpf = 24456198826;
            professor.Apresentar();
        }
    }
}
