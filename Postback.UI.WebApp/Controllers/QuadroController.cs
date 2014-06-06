using Postback.Dominio;
using PostBack.Infra.Repositorios;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class QuadroController : Controller
    {
        private readonly IQuadroRepositorio _quadroRepositorio;
        public PostItRepositorio postItRepositorio = new PostItRepositorio();

        public QuadroController(IQuadroRepositorio quadroRepositorio)
        {
            _quadroRepositorio = quadroRepositorio;
        }

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