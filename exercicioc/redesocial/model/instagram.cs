namespace redesocial.Model{
    public class Instagram : RedeSocial{
        //atributos
        public string data{get;set;}

        //metodos
        public string GetUltimaPubli(){
            return data;
        }

        public void SetUltimaPubli(string data){
            this.data = data; //this = essa classe
        }

        public virtual void ImprimeDado(){
            Console.WriteLine("Usuário: " + this.Usuario);
            Console.WriteLine("Senha: " + this.Senha);
            Console.WriteLine("ultima publicacao no insta: " + this.GetUltimaPubli());
        }
    }
}