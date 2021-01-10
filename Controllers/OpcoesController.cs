using System;
using MVC.Views;

namespace MVC.Controllers
{
    public class OpcoesController
    {
        ProdutoController prod = new ProdutoController();
        ClienteController cliente = new ClienteController();

        OpcoesView opcoesView = new OpcoesView();

        public OpcoesController(){
            int opcaoSelecionada = -1;
            do
            {
                opcaoSelecionada = opcoesView.ListarOpcoes();

                switch (opcaoSelecionada)
                {
                    case 1:
                        cliente.Cadastrar();
                        break;
                    case 2: 
                        cliente.ListarClientes();
                        break;
                    case 3:
                        prod.Cadastrar();
                        break;
                    case 4:
                        prod.ListarProdutos();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por usar nossa aplicação");
                        break;
                    default:
                        break;
                }
                
                
            } while (opcaoSelecionada != 0);


        }
    }
}