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
        public static List<Carros> carros = new List<Carros>();
        public static List<Marcas> marcas = new List<Marcas>();

        static void Main(string[] args)
        {
            int opcao = 0;

            //iniciando marcas
            Marcas m1 = new Marcas(1001, "Volkswagen", "Alemanhã");
            Marcas m2 = new Marcas(1002, "General Motors", "EUA");

            //iniciando carros
            Carros c1 = new Carros(101, "Fusca ", 1980, 15000, m1); m1.addCarro(c1);
            Carros c2 = new Carros(102, "Golf  ", 2016, 60000, m1); m1.addCarro(c2);
            Carros c3 = new Carros(103, "Fox   ", 2017, 30000, m1); m1.addCarro(c3);
            Carros c4 = new Carros(104, "Cruze ", 2016, 30000, m2); m2.addCarro(c4);
            Carros c5 = new Carros(105, "Cobalt", 2015, 25000, m2); m2.addCarro(c5);
            Carros c6 = new Carros(106, "Cobalt", 2017, 35000, m2); m2.addCarro(c6);

            // ARMAZENANDO AS MARCAS E CARROS NAS LISTAS LOCAIS DO PROGRAMA:
            marcas.Add(m1);
            marcas.Add(m2);
            carros.Add(c1);
            carros.Add(c2);
            carros.Add(c3);
            carros.Add(c4);
            carros.Add(c5);
            carros.Add(c6);

            //Tela Menu de escolhas
            Tela.mostrarMenu();

            while (opcao != 7)
            {
                Console.Clear();

                //Tela Menu de escolhas
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\tErro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();


                //estrutura para escolha das opções de menus!
                switch (opcao)
                {
                    case 1:
                        Tela.MostrarMarcas();
                        Console.Write("\tAperte tecla enter para outra opção.");
                        Console.ReadLine();
                        break;

                    case 2:
                        try
                        {
                            Tela.MostrarCarrosDeUmaMarca();
                        }
                        catch(ModelException e)
                        {
                            Console.WriteLine("\tErro de Negócio. " + e.Message);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("\tErro inesperado. " + e.Message);
                        }
                        Console.WriteLine();
                        Console.Write("\tAperte tecla enter para outra opção.");
                        Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("\tFim do programa!");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("\tOpção inválida!");
                        Console.WriteLine();
                        break;

                }

            }

            Console.WriteLine();
            Console.Write("\tAperte tecla enter para sair.");
            Console.ReadLine();
        }
    }
}
