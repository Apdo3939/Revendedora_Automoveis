using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revendedora_Automoveis.Classes
{
    class Marcas
    {
        //atributos
        public int codigoMarca { get; set; }
        public string nomeMarca { get; set; }
        public string paisMarca { get; set; }
        
        //construtor
        public Marcas(int codigoMarca, string nomeMarca, string paisMarca)
        {
            this.codigoMarca = codigoMarca;
            this.nomeMarca = nomeMarca;
            this.paisMarca = paisMarca;
        }

        //Impresão da classe para o usuário
        public override string ToString()
        {
            string s = "LISTAGEM DE MARCAS:\n";
            s =  s + "\t" + codigoMarca + ", " + nomeMarca + ", País: " + paisMarca + ", Número de carros: ";
            return s;
        }
        //metodo para contar carros de uma marca
        public int ContaCarrosMarca()
        {
            return 0;
        }
    }
}
