using Postback.Dominio;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class PostItController : Controller
    {
        private readonly IQuadroRepositorio _quadroRepositorio;

        public PostItController(IQuadroRepositorio quadroRepositorio)
        {
            _quadroRepositorio = quadroRepositorio;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Criar()
        {
            return View();
        }
    }
}