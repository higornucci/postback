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
        public QuadroRepositorio quadroRepositorio = new QuadroRepositorio();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Exibir(int id)
        {
            var quadro = quadroRepositorio.Obter(id);

            //var grupos = AgrupadorDePostIt.Agrupar(postItsDoEvento);
            var grupos = AgrupadorDePostIt.PegaExemplo();

            var exibirQuadroViewModel = new ExibirQuadroViewModel()
            {
                Quadro = quadro,
                Grupos = grupos
            };

            return View(exibirQuadroViewModel);
        }
	}

    public class ExibirQuadroViewModel
    {
        public Quadro Quadro { get; set; }
        public IEnumerable<Grupo> Grupos { get; set; }
    }
}