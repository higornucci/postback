using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Postback.Dominio;
using System.Web.Mvc;
using Postback.UI.WebApp.ViewModels;

namespace Postback.UI.WebApp.Controllers
{
    public class PostItController : Controller
    {
        private readonly IQuadroRepositorio _quadroRepositorio;
        private readonly IPostItRepositorio _postItRepositorio;
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly ISugestaoDeTagRepositorio _sugestaoDeTagRepositorio;

        public PostItController(IQuadroRepositorio quadroRepositorio, IPostItRepositorio postItRepositorio, 
            ICategoriaRepositorio categoriaRepositorio, ISugestaoDeTagRepositorio sugestaoDeTagRepositorio)
        {
            _quadroRepositorio = quadroRepositorio;
            _postItRepositorio = postItRepositorio;
            _categoriaRepositorio = categoriaRepositorio;
            _sugestaoDeTagRepositorio = sugestaoDeTagRepositorio;
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

        public JsonResult SugerirTags(string termo)
        {
            var lista = _sugestaoDeTagRepositorio.ObterTodos().Select(x => new {id = "tag_" + x.Nome, label = x.Nome, value = x.Nome});

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Post(PostItVm postItVm)
        {
            var categoria = _categoriaRepositorio.ObterPor(postItVm.CategoriaId);
            var quadro = _quadroRepositorio.ObterPor(postItVm.QuadroId);
            var tag = new Tag(postItVm.TagNome);

            var postIt = new PostIt(postItVm.Conteudo, quadro, categoria, tag);
            _postItRepositorio.Adicionar(postIt);

            return Json(new { sucesso = true });
        }
}
}