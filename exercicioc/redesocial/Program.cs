// See https://aka.ms/new-console-template for more information
using redesocial.Model;
    namespace redesocial{
        public class Program{
            public static void Main(){
                var rede = new Instagram();
                rede.Usuario = "fulanin";
                rede.Senha = "123456";
                rede.SetUltimaPubli("12/07/3002");
                rede.ImprimeDado();
            }
        }
    }