using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ClienteController
    {
        //Models
        Cliente cliente = new Cliente();

        //Views
        ClienteView clienteView = new ClienteView();

        public void Cadastrar(){
            cliente.Inserir(clienteView.CadastrarCliente());
        }

        public void ListarClientes(){
            clienteView.Listar(cliente.Ler());
        }

        public void Delete(){
            cliente.Deletar(clienteView.Deletar());
        }
        //Retornar Lista de Cliente
        //Apagar Cliente
        //Editar Cliente
        

    }
}