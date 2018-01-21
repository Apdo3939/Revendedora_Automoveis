using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revendedora_Automoveis.Classes
{
    class Acessorios
    {
        //atributos
        public string nomeAcessorio { get; set; }
        public double precoMarca { get; set; }

        //construtor
        public Acessorios()
        {

        }

        //Impresão da classe para o usuário
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
