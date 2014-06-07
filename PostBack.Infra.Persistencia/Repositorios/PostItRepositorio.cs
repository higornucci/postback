using NHibernate;
using Postback.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public class PostItRepositorio : RepositorioBase<PostIt>, IPostItRepositorio
    {
        public PostItRepositorio(ISession sessao) : base(sessao) { }

        public IEnumerable<PostIt> ObterPorQuadro(Quadro quadro)
        {
            return All().Where(postIt => postIt.Quadro == quadro).ToList();
        }
    }
}