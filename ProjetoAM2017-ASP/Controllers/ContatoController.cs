using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAM2017_ASP.Models;

namespace ProjetoAM2017_ASP.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult CadastrarContato()
        {
            ViewBag.Title = "Contate a equipe da Scapay!";
            ViewBag.Message = "Para mais informações, sugestões e elogios, preencha o formulário e envie seu comentário.";

            return View();
        }

        [HttpPost]
        public ActionResult CadastrarContato(Contato co)
        {
            RepositorioContato.Instance().IncluirContato(co);
            return RedirectToAction("SucessoContato");
        }


        public ActionResult SucessoContato()
        {
            ViewBag.Title = "Contato enviado com sucesso!";
            return View();
        }

        //Não ha necessidade de usar esses campos
       /* public ActionResult ListarContatos()
        {
            var contatos = RepositorioContato.Instance().ListarContatos();
            return View(contatos);
        }

       public ActionResult EditarContato(int id)
        {
            var contato = RepositorioContato.Instance().ListarContato(id);
            return View("CadastrarContato", contato);
        }

        [HttpPost]
        public ActionResult EditarContato(Contato co)
        {
            RepositorioContato.Instance().AlterarContato(co);
            return RedirectToAction("ListarContatos");
        }*/

    }
}