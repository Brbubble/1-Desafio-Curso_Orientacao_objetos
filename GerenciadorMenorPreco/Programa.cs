
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorMenorPreco
{
    public class Programa
    {
        static List<Mercadoria> estoque = new List<Mercadoria>();
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Estoque");
                Console.WriteLine("1 - Ver Estoque");
                Console.WriteLine("2 - Adicionar Mercadoria");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("==============================");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        VerEstoque();
                        break;
                    case "2":
                        AdicionarMercadoria();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void VerEstoque()
        {
            Console.Clear();
            Console.WriteLine("Estoque");

            if (estoque.Count == 0)
            {
                Console.WriteLine("O estoque está vazio.");
            }
            else
            {
                foreach (var mercadoria in estoque)
                {
                    Console.WriteLine($"Nome: {mercadoria.Nome}");
                    Console.WriteLine($"Fabricante: {mercadoria.Fabricante}");
                    Console.WriteLine($"Código de Barras: {mercadoria.CodigoBarras}");
                    Console.WriteLine($"Valor de Venda: {mercadoria.ValorVenda:C2}");
                    Console.WriteLine($"Valor de Compra: {mercadoria.ValorCompra:C2}");
                    Console.WriteLine($"Quantidade em Estoque: {mercadoria.QuantidadeEstoque}");
                    Console.WriteLine("--------------------");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void AdicionarMercadoria()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Mercadoria");

            Mercadoria novaMercadoria = new Mercadoria();

            Console.Write("Nome: ");
            novaMercadoria.Nome = Console.ReadLine();

            Console.Write("Fabricante: ");
            novaMercadoria.Fabricante = Console.ReadLine();

            Console.Write("Código de Barras: ");
            novaMercadoria.CodigoBarras = Console.ReadLine();

            Console.Write("Valor de Venda: ");
            novaMercadoria.ValorVenda = double.Parse(Console.ReadLine());

            Console.Write("Valor de Compra: ");
            novaMercadoria.ValorCompra = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em Estoque: ");
            novaMercadoria.QuantidadeEstoque = int.Parse(Console.ReadLine());

            estoque.Add(novaMercadoria);

            Console.WriteLine("Mercadoria adicionada ao estoque!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}






