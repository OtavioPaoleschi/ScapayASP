using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAM2017_ASP.Models;

namespace ProjetoAM2017_ASP.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Index()
        {
            ViewBag.Title = "Bem-Vindo";
            return View();
        }

        //Realizar login de administrador
        public ActionResult Login()
        {
            ViewBag.Title = "Login SCAPAY";
            return View();
        }

        //Validação de Usuario encaminhar para Listar Noticias
        [HttpPost]
        public ActionResult Login(string usuario, string senha)
        {
            return RedirectToAction("Index");
        }

        //Listar noticias
        public ActionResult ListarNoticias()
        {
            var noticias = RepositorioNoticia.Instance().ListarNoticias();
            return View(noticias);
        }

        //Cadastrar noticias
        public ActionResult CadastrarNoticia()
        {
            return View();
        }

        //Cadastrar noticias
        [HttpPost]
        public ActionResult CadastrarNoticia(Noticia n)
        {
            RepositorioNoticia.Instance().IncluirNoticia(n);
            return RedirectToAction("ListarNoticias");
        }

        //noticias
        public ActionResult ExcluirNoticias(int id)
        {
            RepositorioNoticia.Instance().DeletarNoticia(id);
            return RedirectToAction("ListarNoticias");
        }

        //Editar noticias
        public ActionResult EditarNoticia(int id)
        {
            var noticia = RepositorioNoticia.Instance().ListarNoticia(id);
            return View("CadastrarNoticia", noticia);
        }

        //Editar noticias
        [HttpPost]
        public ActionResult EditarNoticia(Noticia n)
        {
            RepositorioNoticia.Instance().AlterarNoticia(n);
            return RedirectToAction("ListarNoticias");
        }

        //Litar Contato
        public ActionResult ListarContatos()
        {
            var contatos = RepositorioContato.Instance().ListarContatos();
            return View(contatos);
        }

        //Excluir Contato
        public ActionResult ExcluirContato(int id)
        {
            RepositorioContato.Instance().DeletarContato(id);
            return RedirectToAction("ListarContatos");
        }

        //Listar Cliente
        public ActionResult ListarClientes()
        {
            var clientes = RepositorioCliente.Instance().ListarClientes();
            return View(clientes);
        }

        //Excluir Cliente 
        public ActionResult ExcluirCliente(int id)
        {
            RepositorioCliente.Instance().DeletarCliente(id);
            return RedirectToAction("ListarClientes");
        }


    }
}