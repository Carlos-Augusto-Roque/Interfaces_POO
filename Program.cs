using System;
using Interfaces.classes;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 001;
            p1.Nome = "BMW";
            p1.Preco = 98000;

            Produto p2 = new Produto();
            p2.Codigo = 002;
            p2.Nome = "FERRARI";
            p2.Preco = 1000000;

            Produto p3 = new Produto();
            p3.Codigo = 003;
            p3.Nome = "PORSCHE";
            p3.Preco = 900000;

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Blue;
            carrinho.Alterar(p1.Codigo,p3);
            System.Console.WriteLine("Lista alterada:");
            carrinho.Listar();
            Console.ResetColor();

        }
    }
}
