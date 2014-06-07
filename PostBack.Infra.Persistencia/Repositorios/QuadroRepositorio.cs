using NHibernate;
using Postback.Dominio;
using System.Linq;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public class QuadroRepositorio : RepositorioBase<Quadro>, IQuadroRepositorio
    {
        public QuadroRepositorio(ISession sessao) : base(sessao) { }

        public Quadro ObterAtivo()
        {
            return All().FirstOrDefault(q => q.Ativo);
        }
    }
}