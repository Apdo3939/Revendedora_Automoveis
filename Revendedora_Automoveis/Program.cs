using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revendedora_Automoveis.Classes;

namespace Revendedora_Automoveis
{
    class Program
    {
        public static List<Carros> listcarros = new List<Carros>();
        public static List<Marcas> listmarcas = new List<Marcas>();

        static void Main(string[] args)
        {
            int opcao = 0;

            //iniciando carros
            listcarros.Add(new Carros(101, "Fusca ", 1980, 15000));
            listcarros.Add(new Carros(102, "Golf  ", 2016, 60000));
            listcarros.Add(new Carros(103, "Fox   ", 2017, 30000));
            listcarros.Add(new Carros(104, "Cruze ", 2016, 30000));
            listcarros.Add(new Carros(105, "Cobalt", 2015, 25000));
            listcarros.Add(new Carros(106, "Cobalt", 2017, 35000));

            //iniciando marcas
            listmarcas.Add(new Marcas(1001, "Volkswagen", "Alemanhã"));
            listmarcas.Add(new Marcas(1002, "General Motors", "EUA"));

            Console.WriteLine();

            //estrutura para escolha das opções de menus!
            switch (opcao)
            {
                case 1:
                    Console.Clear();

                    break;
                default:
                    break;

            }


            for (int i = 0; i < listcarros.Count; i++)
            {
                Console.WriteLine("\t" + listcarros[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < listmarcas.Count; i++)
            {
                Console.WriteLine("\t" + listmarcas[i]);
            }

            Console.ReadLine();
        }
    }
}
