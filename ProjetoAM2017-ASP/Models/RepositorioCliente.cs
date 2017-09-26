using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAM2017_ASP.Models
{
    public class RepositorioCliente
    {
        private static RepositorioCliente _repositorioCliente;
        private List<Cliente> clientes;
        
        //construtor privado
        private RepositorioCliente()
        {
            clientes = new List<Cliente>();
        }

        // metodo para garantir que seja instaciado apenas uma vez
        public static    RepositorioCliente Instance()
        {
            if(_repositorioCliente == null)
            {
                _repositorioCliente = new RepositorioCliente();
            }
            return _repositorioCliente;
        }

        //incluir cliente
        public void IncluirCliente(Cliente cli)
        {
            clientes.Add(cli);
        }

        //Listar todos os clientes 
        public IEnumerable<Cliente> ListarClientes()
        {
            return clientes;
        }

        //procurar cliente por codigo
        public Cliente ListarCliente(int codigo)
        {
            var cliente = clientes.Where(f => f.Codigo == codigo).First();
            return cliente;
        }

        //excluir cliente por email
        public void DeletarCliente(int codigo)
        {
            clientes.Remove(ListarCliente(codigo));
        }

        //Alterar Cliente
        public void AlterarCliente(Cliente cli)
        {
            clientes.Where(f => f.Codigo == cli.Codigo).ToList()
                .ForEach(s =>
                {
                    s.Email = cli.Email;
                    s.Nome = cli.Nome;
                    s.Cpf = cli.Cpf;
                    s.Tel = cli.Tel;

                });
        }
    }
}