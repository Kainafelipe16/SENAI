namespace animal.Model {
    public abstract class Animal {
        public string Especie { get; set; }

        public abstract void EmitirSom();
    }
}