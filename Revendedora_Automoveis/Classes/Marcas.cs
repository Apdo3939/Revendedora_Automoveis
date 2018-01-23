using System.Collections.Generic;

namespace Revendedora_Automoveis.Classes
{
    class Marcas
    {
        //atributos
        public int codigoMarca { get; set; }
        public string nomeMarca { get; set; }
        public string paisMarca { get; set; }
        public List<Carros> carros { get; set; }
        
        //construtor
        public Marcas(int codigoMarca, string nomeMarca, string paisMarca)
        {
            this.codigoMarca = codigoMarca;
            this.nomeMarca = nomeMarca;
            this.paisMarca = paisMarca;
            carros = new List<Carros>();
        }

        public void addCarro(Carros c)
        {
            carros.Add(c);
            carros.Sort();
        }

        //Impresão da classe para o usuário
        public override string ToString()
        {
            return codigoMarca
                + ", "
                + nomeMarca
                + ", País: "
                + paisMarca
                + ", Números de Carros: "
                + carros.Count;
        }
    }
}//OK Classe Pronta
