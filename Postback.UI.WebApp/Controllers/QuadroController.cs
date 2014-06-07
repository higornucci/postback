using Postback.Dominio;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class QuadroController : Controller
    {
        private readonly IQuadroRepositorio _quadroRepositorio;

        public QuadroController(IQuadroRepositorio quadroRepositorio)
        {
            _quadroRepositorio = quadroRepositorio;
        }

        public ActionResult Index(int id)
        {
            var postItsDoQuadro = new List<PostIt>();

            postItsDoQuadro.AddRange(PostItBuilder.VariosPostItsDaCategoria("Bom", "#53da3f"));
            postItsDoQuadro.AddRange(PostItBuilder.VariosPostItsDaCategoria("Melhorar", "#5bb4e5"));
            postItsDoQuadro.AddRange(PostItBuilder.VariosPostItsDaCategoria("Aprendi", "#fee000"));

            postItsDoQuadro[1].Tag = new Tag("Diferente");

            var grupos = AgrupadorDePostIt.Agrupar(postItsDoQuadro);
            //var grupos = AgrupadorDePostIt.PegaExemplo();

            var exibirQuadroViewModel = new ExibirQuadroViewModel()
            {
                Quadro = QuadroBuilder.UmQuadro().Criar(),
                Grupos = grupos
            };

            return View(exibirQuadroViewModel);
        }
    }

    public class QuadroBuilder
    {
        public static QuadroBuilder UmQuadro()
        {
            return new QuadroBuilder();
        }

        public Quadro Criar()
        {
            return new Quadro()
            {
                Categorias = CategoriaBuilder.VariasCategorias(),
                Descricao = "Hackathon 2.0"
            };
        }
    }

    public class ExibirQuadroViewModel
    {
        public Quadro Quadro { get; set; }
        public IEnumerable<Grupo> Grupos { get; set; }
    }
}