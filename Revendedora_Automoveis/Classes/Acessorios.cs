using System.Globalization;

namespace Revendedora_Automoveis.Classes
{
    class Acessorios
    {
        //atributos
        public string nomeAcessorio { get; set; }
        public double precoMarca { get; set; }
        public Carros carro { get; set; }

        //construtor
        public Acessorios(string nomeAcessorio, double precoMarca, Carros carro)
        {
            this.nomeAcessorio = nomeAcessorio;
            this.precoMarca = precoMarca;
            this.carro = carro;
        }

        //Impresão da classe para o usuário
        public override string ToString()
        {
            return nomeAcessorio
                + ", Preço: "
                + precoMarca.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}//OK Classe Pronta
