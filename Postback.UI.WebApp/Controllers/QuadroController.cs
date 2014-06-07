using Postback.Dominio;
using Postback.UI.WebApp.ViewModels;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class QuadroController : Controller
    {
        private readonly IQuadroRepositorio _quadroRepositorio;
        private readonly IPostItRepositorio _postItRepositorio;

        public QuadroController(IQuadroRepositorio quadroRepositorio, IPostItRepositorio postItRepositorio)
        {
            _quadroRepositorio = quadroRepositorio;
            _postItRepositorio = postItRepositorio;
        }

        public ActionResult Index()
        {
            var quadroAtivo = _quadroRepositorio.ObterAtivo();
            var postItsDoQuadro = _postItRepositorio.ObterPorQuadro(quadroAtivo);

            var grupos = AgrupadorDePostIt.Agrupar(postItsDoQuadro);
            var exibirQuadroViewModel = new QuadroAtivoVm
            {
                QuadroDescricao = quadroAtivo.Descricao,
                Grupos = grupos
            };

            return View(exibirQuadroViewModel);
        }
    }
}