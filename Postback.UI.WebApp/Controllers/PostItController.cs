using Postback.Dominio;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class PostItController : Controller
    {
        private readonly IQuadroRepositorio _quadroRepositorio;
        private readonly IPostItRepositorio _postItRepositorio;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public PostItController(IQuadroRepositorio quadroRepositorio, IPostItRepositorio postItRepositorio)
        {
            _quadroRepositorio = quadroRepositorio;
            _postItRepositorio = postItRepositorio;
            //_categoriaRepositorio = categoriaRepositorio;
        }

        public ActionResult Index()
        {
            PrepararDropDown();

            return View();
        }

        private void PrepararDropDown()
        {
            var itens = new SelectListItem[]
            {
                new SelectListItem() {Selected = true, Text = "Selecione uma categoria", Value = ""},
                new SelectListItem() {Selected = false, Text = "Bom", Value = "Bom"},
                new SelectListItem() {Selected = false, Text = "Melhorar", Value = "Melhorar"},
                new SelectListItem() {Selected = false, Text = "Aprendizado", Value = "Aprendizado"},
            };

            ViewBag.Categorias = new SelectList(itens, "Value", "Text");
        }

        [HttpPost]
        public ActionResult Criar(PostIt postIt)
        {
            return View();
        }
    }
}