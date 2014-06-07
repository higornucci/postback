using System.Collections.Generic;
using NHibernate;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public class SugestaoDeTagRepositorio : RepositorioBase<SugestaoDeTag>, ISugestaoDeTagRepositorio
    {
        public SugestaoDeTagRepositorio(ISession sessao) : base(sessao) { }
        
        public IEnumerable<SugestaoDeTag> ObterTodos()
        {
            return Enumerar();
        }
    }
}