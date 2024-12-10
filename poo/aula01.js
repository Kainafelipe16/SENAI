class Inseto {
    _especie;
    quantPatas;
    quantOlhos;

    constructor(especie, quantPatas, quantOlhos) {
        this._especie = especie;
        this.quantPatas = quantPatas;
        this.quantOlhos = quantOlhos;
    }

    get especie() {
        return this._especie;
    }

    set especie(valor) {
        this._especie = valor;
    }

    imprimeDados() {
        document.write("especie: " + this._especie + " - quantPatas: " + this.quantPatas + " - quantOlhos: " + this.quantOlhos);
    }
}

let Ins = new Inseto("Formiga ", 6 , 2 );

Ins.imprimeDados();