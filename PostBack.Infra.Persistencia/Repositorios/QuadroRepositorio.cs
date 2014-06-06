using NHibernate;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public class QuadroRepositorio : RepositorioBase<Quadro>, IQuadroRepositorio
    {
        public QuadroRepositorio(ISession sessao) : base(sessao) { }
    }
}