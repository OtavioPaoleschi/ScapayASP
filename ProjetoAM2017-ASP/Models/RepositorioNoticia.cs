using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAM2017_ASP.Models
{
    public class RepositorioNoticia
    {
        private static RepositorioNoticia _repositorioNoticia;
        private List<Noticia> noticias;

        //Construtor privado
        private RepositorioNoticia()
        {
            noticias = new List<Noticia>();
        }

        // metodo para garantir que seja instaciado apenas uma vez
        public static RepositorioNoticia Instance()
        {
            if (_repositorioNoticia == null)
            {
                _repositorioNoticia = new RepositorioNoticia();
            }
            return _repositorioNoticia;
        }

        //incluir noticia
        public void IncluirNoticia(Noticia not)
        {
            noticias.Add(not);
        }

        //Listar todos os clientes 
        public IEnumerable<Noticia> ListarNoticias()
        {
            return noticias;
        }

        //Procurar Noticia por codigo
        public Noticia ListarNoticia(int codigo)
        {
            var noticia = noticias.Where(f => f.Codigo == codigo).First();
            return noticia;
        }

        //excluir noticia por codigo
        public void DeletarNoticia(int codigo)
        {
            noticias.Remove(ListarNoticia(codigo));
        }

        //Alterar Noticia
        public void AlterarNoticia(Noticia not)
        {
            noticias.Where(f => f.Codigo == not.Codigo).ToList()
                .ForEach(s =>
                {
                    s.Titulo = not.Titulo;
                    s.Texto = not.Texto;
                });
        }
    }
}