using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revendedora_Automoveis.Classes;

namespace Revendedora_Automoveis
{
    class Tela
    {
        // Mostrar o menu Inicial
        public static void mostrarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t**********************************************");
            Console.WriteLine("\t*           REVENDEDORA DE CARROS            *");
            Console.WriteLine("\t**********************************************");
            Console.WriteLine();
            Console.WriteLine("\t1 - Listar marcas");
            Console.WriteLine("\t2 - Listar carros de uma marca ordenadamente");
            Console.WriteLine("\t3 - Cadastrar marca");
            Console.WriteLine("\t4 - Cadastrar carro");
            Console.WriteLine("\t5 - Cadastrar acessório");
            Console.WriteLine("\t6 - Mostrar detalhes de um carro");
            Console.WriteLine("\t7 - Sair");
            Console.WriteLine();
            Console.Write("\tDigite uma opção: ");
        }

        //opção 1 mostrar marcas
        public static void MostrarMarcas()
        {
            Console.WriteLine("\tLISTAGEM DE MARCAS:");
            for (int i = 0; i < Program.marcas.Count; i++)
            {
                Console.WriteLine("\t" + Program.marcas[i]);
            }
            Console.WriteLine();
        }

        //opção 2 Listar carros de uma marca ordenadamente
        public static void MostrarCarrosDeUmaMarca()
        {
            Console.Write("\tDigite o código de uma marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigoMarca == codMarca);
            Console.WriteLine();
            if (pos == -1)
            {
                throw new ModelException("\tCódigo de marca não encontrado: " + codMarca);
            }
            Console.WriteLine("\tCarros da Marca " + Program.marcas[pos].nomeMarca + ":");
            List<Carros> lista = Program.marcas[pos].carros;
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("\t" + lista[i]);
            }
            Console.WriteLine();
        }

    }
}
