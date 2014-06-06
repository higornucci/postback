using NHibernate;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public class SugestaoDeTagRepositorio : RepositorioBase<SugestaoDeTag>
    {
        public SugestaoDeTagRepositorio(ISession sessao) : base(sessao) { }
    }
}