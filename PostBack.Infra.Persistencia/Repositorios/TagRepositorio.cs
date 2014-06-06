using NHibernate;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public class TagRepositorio : RepositorioBase<Tag>
    {
        public TagRepositorio(ISession sessao) : base(sessao) { }
    }
}