using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAM2017_ASP.Models
{
    public class RepositorioContato
    {
        private static RepositorioContato _repositorioContato;
        private List<Contato> contatos;

        //construtor privado
        private RepositorioContato()
        {
            contatos = new List<Contato>();
        }

        // metodo para garantir que seja instaciado apenas uma vez
        public static RepositorioContato Instance()
        {
            if (_repositorioContato == null)
            {
                _repositorioContato = new RepositorioContato();
            }
            return _repositorioContato;
        }

        //incluir Contato
        public void IncluirContato(Contato cont)
        {
            contatos.Add(cont);
        }

        //Listar todos os contatos 
        public IEnumerable<Contato> ListarContatos()
        {
            return contatos;
        }

        //Procurar Contato por codigo
        public Contato ListarContato(int codigo)
        {
            var contato = contatos.Where(f => f.Codigo == codigo).First();
            return contato;
        }

        //excluir contato por codigo
        public void DeletarContato(int codigo)
        {
            contatos.Remove(ListarContato(codigo));
        }

        //Alterar Contato
        public void AlterarContato(Contato cont)
        {
            contatos.Where(f => f.Codigo == cont.Codigo).ToList()
                .ForEach(s =>
                {
                    s.Email = cont.Email;
                    s.Nome = cont.Nome;
                    s.Tel = cont.Tel;
                    s.Comentarios = cont.Comentarios;
                });
        }
    }
}