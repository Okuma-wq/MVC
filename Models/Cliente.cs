using System.Collections.Generic;
using System.IO;


namespace MVC.Models
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        
        private const string PATH = "Database/Cliente.csv";
        
        public Cliente(){
            string pasta = PATH.Split("/")[0];

            if(!Directory.Exists(pasta)){

                Directory.CreateDirectory(pasta);
            
            }

            if(!File.Exists(PATH)){
                
                File.Create(PATH);

            }
        }

        public List<Cliente> Ler(){

            List<Cliente> clientes = new List<Cliente>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Cliente cliente = new Cliente();
                cliente.Codigo = int.Parse(atributos[0]);
                cliente.Nome = atributos[1];
                cliente.CPF = atributos[2];

                clientes.Add(cliente);
            }



            return clientes;
        }

        public int ProximoCodigo(){

            var clientes = Ler();

            if (clientes.Count == 0)
            {
                return 1;
            }
            
            var codigo = clientes[clientes.Count - 1].Codigo;

            codigo ++;
             
            return codigo;
        }

        public void Inserir(Cliente cliente){

            cliente.Codigo = ProximoCodigo();
            
            string[] linhas = {PrepararLinhasCSV(cliente)};

            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhasCSV(Cliente cliente){
            return $"{cliente.Codigo};{cliente.Nome};{cliente.CPF}";
        }

        public List<string> ReadAllLinesCSV(string path){
            
            List<string> linhas = new List<string>();

            using (StreamReader file = new StreamReader(path))
            {
                string linha;
                while ((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }

            return linhas;
        }

        public void RewriteCSV(string path, List<string> linhas)
        {
            using(StreamWriter output = new StreamWriter(path))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + '\n');
                }
            }            
        }
        
        public void Deletar(int _cod){
            List<string> linhas = ReadAllLinesCSV(PATH);

            linhas.RemoveAll(x => x.Split(";")[0] == _cod.ToString());

            RewriteCSV(PATH, linhas);
        }
        
        
        
    }
}