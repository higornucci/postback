using Postback.Dominio;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class PostItController : Controller
    {
        private readonly IQuadroRepositorio _quadroRepositorio;
        private readonly IPostItRepositorio _postItRepositorio;

        public PostItController(IQuadroRepositorio quadroRepositorio, IPostItRepositorio postItRepositorio)
        {
            _quadroRepositorio = quadroRepositorio;
            _postItRepositorio = postItRepositorio;
        }

        //
        // GET: /PostIt/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(PostIt postIt)
        {
            return View();
        }
    }
}