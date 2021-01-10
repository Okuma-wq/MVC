using System;
using System.Collections.Generic;
using System.Globalization;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos){

            Console.WriteLine($"");            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"---------------Lista de Produtos---------------");
            Console.ResetColor();
            Console.WriteLine($"");

            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco.ToString("C")}");
                Console.WriteLine("");
                
                
            }

            
        }
        
        public Produto CadastrarProduto(){

            Produto produto = new Produto();

            Console.WriteLine($"Digite um nome para o produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
            
            
        }
    }
}