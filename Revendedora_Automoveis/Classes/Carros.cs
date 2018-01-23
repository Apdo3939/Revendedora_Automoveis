using System;
using System.Collections.Generic;
using System.Globalization;

namespace Revendedora_Automoveis.Classes
{
    class Carros : IComparable
    {
       //atributos
        public int codigoCarro { get; set; }
        public string modeloCarro { get; set; }
        public int anoCarro { get; set; }
        public double custoBaseCarro { get; set; }
        public Marcas marcaCarro { get; set; }
        public List<Acessorios> acessorios { get; set; }
       

        //construtor
        public Carros(int codigoCarro, string modeloCarro, int anoCarro, double custoBaseCarro, Marcas marca)
        {
            this.codigoCarro = codigoCarro;
            this.modeloCarro = modeloCarro;
            this.anoCarro = anoCarro;
            this.custoBaseCarro = custoBaseCarro;
            this.marcaCarro = marca;
            acessorios = new List<Acessorios>();
            
        }

        //metodo para calcular o preço total
        public double precoTotal()
        {
            double soma = custoBaseCarro;
            for (int i = 0; i < acessorios.Count; i++)
            {
                soma = acessorios[i].precoMarca;
            }
            return soma;
        }

        //Impresão da classe para o usuário
        public override string ToString()
        {
            string s = codigoCarro
                + ", "
                + modeloCarro
                + ", Ano: "
                + anoCarro
                + ", Preço Básico: "
                + custoBaseCarro.ToString("F2", CultureInfo.InvariantCulture);

            if (acessorios.Count > 0)
            {
                s = s + "\nAcessórios: ";
                for (int i = 0; i < acessorios.Count; i++)
                {
                    s = s + "\n" + acessorios[i];
                }
            }

            return s;
        }

        public int CompareTo(object obj)
        {
            Carros outro = (Carros)obj;
            int resultado = modeloCarro.CompareTo(outro.modeloCarro);
            if (resultado != 0)
            {
                return resultado;
            }
            else
            {
                return -precoTotal().CompareTo(outro.precoTotal());
            }
            //throw new NotImplementedException();
        }
    }
}
