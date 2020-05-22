using Primeiro.Models;
using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product x = new Product();

            x.Name = name;
            x.Price = price;

            Console.WriteLine("Dados do produto: " + x);

            Console.WriteLine("Produtos a ADICIONAR no estoque:");
            int quantity = int.Parse(Console.ReadLine());
            x.AddProduct(quantity);
            Console.WriteLine("Dados do produto: " + x);

            Console.WriteLine("Produtos a REMOVER do estoque:");
            quantity = int.Parse(Console.ReadLine());
            x.RemoveProduct(quantity);
            Console.WriteLine("Dados do produto: " + x);

        }
    }
}
