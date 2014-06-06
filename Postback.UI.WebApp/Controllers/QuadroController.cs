using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Postback.Dominio;
using PostBack.Infra.Repositorios;

namespace Postback.UI.WebApp.Controllers
{
    public class QuadroController : Controller
    {
        public PostItRepositorio postItRepositorio = new PostItRepositorio();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Exibir(int id)
        {
            var postItsDoEvento = postItRepositorio.ObterPorEvento(id);

            //var grupos = AgrupadorDePostIt.Agrupar(postItsDoEvento);
            var grupos = AgrupadorDePostIt.PegaExemplo();

            return View(grupos);
        }
	}
}