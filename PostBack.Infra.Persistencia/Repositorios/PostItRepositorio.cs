using NHibernate;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public class PostItRepositorio: RepositorioBase<PostIt>, IPostItRepositorio
    {
        public PostItRepositorio(ISession sessao) : base(sessao) { }
    }
}