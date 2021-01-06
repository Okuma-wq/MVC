using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos){

            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco.ToString("C")}");
                Console.WriteLine("");
                
                
            }
            
        }
    }
}