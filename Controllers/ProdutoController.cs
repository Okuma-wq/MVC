using System.Collections.Generic;
using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        //Models
        Produto produto = new Produto();





        //Views
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos(){

            produtoView.Listar(produto.Ler());
            
        }



    }
}