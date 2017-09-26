using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAM2017_ASP.Models;

namespace ProjetoAM2017_ASP.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult CadastrarCliente()
        {
            ViewBag.Title = "Quero Receber Notícias da Scapay!";
            ViewBag.Message = "Preencha o formulário e cadastre-se.";
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarCliente(Cliente c)
        {
            RepositorioCliente.Instance().IncluirCliente(c);
            return RedirectToAction("SucessoCliente");
        }

        public ActionResult SucessoCliente()
        {
            ViewBag.Title = "Cliente cadastrado com sucesso!";
            return View();
        }

        //Não ha necessidade de utilizar
        /*public ActionResult ListarClientes()
        {
            var clientes = RepositorioCliente.Instance().ListarClientes();
            return View(clientes);
        }

        public ActionResult EditarCliente(int id)
        {
            var cliente = RepositorioCliente.Instance().ListarCliente(id);
            return View("CadastrarCliente", cliente);
        }

        [HttpPost]
        public ActionResult EditarCliente(Cliente c)
        {
            RepositorioCliente.Instance().AlterarCliente(c);
            return RedirectToAction("ListarClientes");
        }*/
    }
}