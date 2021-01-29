using System;

namespace MVC.Views
{
    public class OpcoesView
    {
        public int ListarOpcoes(){

            int resposta = -1;
            var temp = false;

            do{
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Produto");
                Console.WriteLine("4 - Listar Produtos");
                Console.WriteLine("5 - Deletar Cliente");
                Console.WriteLine("0 - Sair");
                temp = int.TryParse(Console.ReadLine(),out resposta);

                if (resposta < 0 || resposta > 6 || temp == false )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"");
                    Console.WriteLine($"Opção inválida, tente novamente");
                    Console.WriteLine($"");                    
                    Console.ResetColor();
                }
                
                
            }while(resposta < 0 || resposta > 6 || temp == false);

            return resposta;
        }
        
    }
}