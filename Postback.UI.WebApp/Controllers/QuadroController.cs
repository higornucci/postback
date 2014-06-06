﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Postback.Dominio;

namespace Postback.UI.WebApp.Controllers
{
    public class QuadroController : Controller
    {
        private readonly IQuadroRepositorio _quadroRepositorio;

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
            List<PostIt> postItsDoQuadro = new List<PostIt>();

            postItsDoQuadro.AddRange(PostItBuilder.VariosPostItsDaCategoria("Bom"));
            postItsDoQuadro.AddRange(PostItBuilder.VariosPostItsDaCategoria("Melhorar"));
            postItsDoQuadro.AddRange(PostItBuilder.VariosPostItsDaCategoria("Aprendi"));

            postItsDoQuadro[1].Assunto = new Tag(){Nome="Diferente"};

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
                Descricao = "Hackathon"
            };
        }
    }

    public class ExibirQuadroViewModel
    {
        public Quadro Quadro { get; set; }
        public IEnumerable<Grupo> Grupos { get; set; }
    }
}