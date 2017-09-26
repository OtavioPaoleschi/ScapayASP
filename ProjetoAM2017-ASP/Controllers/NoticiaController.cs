using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAM2017_ASP.Models;

namespace ProjetoAM2017_ASP.Controllers
{
    public class NoticiaController : Controller
    {
        // GET: Noticia
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarNoticias()
        {
            var noticias = RepositorioNoticia.Instance().ListarNoticias();
            return View(noticias);
        }

    }
}