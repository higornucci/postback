using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Postback.Dominio
{
    public class AgrupadorDePostIt
    {

        public static IEnumerable<Grupo> Agrupar(IEnumerable<PostIt> postIts)
        {
            var grupos = new List<Grupo>();

            foreach (var grupoDeCategoria in postIts.GroupBy(x => x.Categoria))
            {
                var categoria = grupoDeCategoria.Key;
                foreach (var grupoDeAssunto in postIts.Where(x => x.Categoria == categoria).GroupBy(x => x.Assunto))
                {
                    var assunto = grupoDeAssunto.Key;

                    var grupo = new Grupo(postIts.Where(x => x.Assunto == assunto && x.Categoria == categoria));

                    grupos.Add(grupo);
                }
            }

            return grupos;
        }

        public static IEnumerable<Grupo> PegaExemplo()
        {
            return new List<Grupo>()
            {
                GrupoBuilder.UmGrupo().ComPostIts(PostItBuilder.VariosPostItsDaCategoria("Bom")).Criar(),
                GrupoBuilder.UmGrupo().ComPostIts(PostItBuilder.VariosPostItsDaCategoria("Melhorar")).Criar(),
                GrupoBuilder.UmGrupo().ComPostIts(PostItBuilder.VariosPostItsDaCategoria("Aprendi")).Criar(),
            };
        }
    }

    public class PostItBuilder
    {
        private Tag _tag = TagBuilder.UmaTag().Criar();
        private Categoria _categoria;
        private string _conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sit amet eleifend ante, non ultricies libero. Etiam arcu enim, auctor.";

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
            return new PostIt() {Assunto = _tag, Categoria = _categoria, Conteudo = _conteudo};
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
            return new Categoria(descricao: _descricao, corEmHexadecimal:_cor);
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
            return new Tag() {Nome = _nome};
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
            return new Grupo( _postIts);
        }

        public GrupoBuilder ComPostIts(IEnumerable<PostIt> postIts)
        {
            _postIts = postIts;
            return this;
        }
    }
}