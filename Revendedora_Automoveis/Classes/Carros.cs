using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revendedora_Automoveis.Classes
{
    class Carros 
    {
       

        //atributos
        public int codigoCarro { get; set; }
        public string modeloCarro { get; set; }
        public int anoCarro { get; set; }
        public double custoBaseCarro { get; set; }
        public Marcas marcaCarro { get; set; }
       

        //construtor
        public Carros(int codigoCarro, string modeloCarro, int anoCarro, double custoBaseCarro)
        {
            this.codigoCarro = codigoCarro;
            this.modeloCarro = modeloCarro;
            this.anoCarro = anoCarro;
            this.custoBaseCarro = custoBaseCarro;
            
        }

        //Impresão da classe para o usuário
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
