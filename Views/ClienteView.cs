using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.Views
{
    public class ClienteView
    {
        public Cliente CadastrarCliente(){
            
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite o nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente: ");
            cliente.CPF = Console.ReadLine();
            Console.WriteLine("");
            

            return cliente;
        }

        public void Listar(List<Cliente> clientes){
            
            Console.WriteLine($"");            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"---------------Lista de Clientes---------------");
            Console.ResetColor();
            Console.WriteLine($"");
            
            

            foreach (var item in clientes)
            {
                Console.WriteLine($"Código do cliente: {item.Codigo}");
                Console.WriteLine($"Nome do cliente: {item.Nome}");
                Console.WriteLine($"CPF: {item.CPF}");
                Console.WriteLine("");
                
                
            }

            
        }
    }
}