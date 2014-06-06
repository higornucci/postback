using System;
using System.Collections.Generic;
using System.Linq;

namespace Postback.Dominio
{
    public class AgrupadorDePostIt
    {

        public static IEnumerable<Grupo> Agrupar(IEnumerable<PostIt> postIts)
        {
            var grupos = new List<Grupo>();

            foreach (var grupoDeCategoria in postIts.GroupBy(x => x.Categoria))
            {
                var categoria = grupoDeCategoria.Key.Descricao;
                foreach (var grupoDeAssunto in postIts.Where(x => x.Categoria.Descricao == categoria).GroupBy(x => x.Tag))
                {
                    var assunto = grupoDeAssunto.Key.Nome;

                    var grupo = new Grupo(postIts.Where(x => x.Tag.Nome == assunto && x.Categoria.Descricao == categoria));

                    grupos.Add(grupo);
                }
            }

            return grupos;
        }

        public static IEnumerable<Grupo> PegaExemplo()
        {
            var grupos = new List<Grupo>()
            {
                GrupoBuilder.UmGrupo().ComPostIts(PostItBuilder.VariosPostItsDaCategoria("Bom")).Criar(),
                GrupoBuilder.UmGrupo().ComPostIts(PostItBuilder.VariosPostItsDaCategoria("Melhorar")).Criar(),
                GrupoBuilder.UmGrupo().ComPostIts(PostItBuilder.VariosPostItsDaCategoria("Aprendi")).Criar(),
            };
            return grupos;
        }
    }

    public class PostItBuilder
    {
        private Tag _tag = TagBuilder.UmaTag().Criar();
        private Categoria _categoria;
        private string _conteudo = Guid.NewGuid().ToString();

        public static IEnumerable<PostIt> VariosPostIts()
        {
            return Enumerable.Range(0, 3).Select(source => PostItBuilder.UmPostIt().Criar()).ToList();
        }

        public static IEnumerable<PostIt> VariosPostItsDaCategoria(string descricaoDaCategoria)
        {
            return Enumerable.Range(0, 3).Select(source => PostItBuilder.UmPostIt()
                .DaCategoria(CategoriaBuilder.UmaCategoria().ComDescricao(descricaoDaCategoria).Criar())
                .Criar()).ToList();
        }

        private PostItBuilder DaCategoria(Categoria categoria)
        {
            _categoria = categoria;
            return this;
        }

        private PostIt Criar()
        {
            return new PostIt() { Tag = _tag, Categoria = _categoria, Conteudo = _conteudo };
        }

        public static PostItBuilder UmPostIt()
        {
            return new PostItBuilder();
        }
    }

    public class CategoriaBuilder
    {
        private string _descricao;
        private string _cor = "#000";

        public static CategoriaBuilder UmaCategoria()
        {
            return new CategoriaBuilder();
        }

        public CategoriaBuilder ComDescricao(string descricaoDaCategoria)
        {
            _descricao = descricaoDaCategoria;
            return this;
        }

        public Categoria Criar()
        {
            return new Categoria(descricao: _descricao, corEmHexadecimal: _cor);
        }

        public static IEnumerable<Categoria> VariasCategorias()
        {
            var categorias = new List<Categoria>();
            var descricaoDasCategorias = "Bom,Melhorar,Aprendi".Split(',');

            return descricaoDasCategorias.Select(x => CategoriaBuilder.UmaCategoria().ComDescricao(x).Criar());
        }
    }

    internal class TagBuilder
    {
        private string _nome = "UMA TAG";

        public static TagBuilder UmaTag()
        {
            return new TagBuilder();
        }

        public TagBuilder ComTag(string nome)
        {
            _nome = nome;
            return this;
        }

        public Tag Criar()
        {
            return new Tag(_nome);
        }
    }

    public class GrupoBuilder
    {
        private IEnumerable<PostIt> _postIts;

        public static GrupoBuilder UmGrupo()
        {
            return new GrupoBuilder();
        }

        public Grupo Criar()
        {
            return new Grupo(_postIts);
        }

        public GrupoBuilder ComPostIts(IEnumerable<PostIt> postIts)
        {
            _postIts = postIts;
            return this;
        }
    }
}