using System;
using System.Globalization;
using System.Collections.Generic;
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

        //opção 3 Cadastrar marca
        public static void CadastrarMarca()
        {
            Console.WriteLine("\tDigite os dados da marca: ");
            Console.Write("\tCódigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("\tNome: ");
            string nome = Console.ReadLine();
            Console.Write("\tPaís de origem: ");
            string pais = Console.ReadLine();
            Marcas M = new Marcas(codigo, nome, pais);
            Program.marcas.Add(M);

        }

        //opção 4 Cadastrar carro
        public static void CadastrarCarro()
        {
            Console.WriteLine("\tDigite os dados do carro: ");
            Console.Write("\tMarca (código): ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigoMarca == codMarca);
            if (pos == -1)
            {
                throw new ModelException("\tCódigo de marca não encontrado: " + codMarca);
            }
            Console.Write("\tCódigo do carro: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("\tModelo: ");
            string modelo = Console.ReadLine();
            Console.Write("\tAno: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("\tPreço básico: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Marcas M = Program.marcas[pos];
            Carros C = new Carros(codigo, modelo, ano, preco, M);
            M.addCarro(C);
            Program.carros.Add(C);
        }

        //opção 5 Cadastrar acessório
        public static void CadastrarAcessorio()
        {
            Console.WriteLine("\tDigite os dados do acessório: ");
            Console.Write("\tCarro (código): ");
            int codcarro = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigoCarro == codcarro);
            if (pos == -1)
            {
                throw new ModelException("\tCódigo de carro não encontrado: " + codcarro);
            }
            Console.Write("\tDescrição: ");
            string nome = Console.ReadLine();
            Console.Write("\tPreço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Carros C = Program.carros[pos];
            Acessorios A = new Acessorios(nome, preco, C);
            C.acessorios.Add(A);
        }

        //opção 6 mostrar detalhes de um carro
        public static void MostrarDetalhesCarro (List<Carros> carros)
        {
            Console.Write("\tDigite o código do carro: ");
            int codcarro = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigoCarro == codcarro);
            if (pos == -1)
            {
                throw new ModelException("\tCódigo de carro não encontrado: " + codcarro);
            }
            Console.WriteLine("\t" + carros[pos]);
            Console.WriteLine();

        }
        //fim do programa
        public static void FimPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("\t**********************************************");
            Console.WriteLine("\t*           REVENDEDORA DE CARROS            *");
            Console.WriteLine("\t**********************************************");

        }


    }
}
