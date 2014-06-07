using System.Collections.Generic;
using System.Linq;
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

        public SugestaoDeTag ObterPorTag(Tag tag)
        {
            return All().FirstOrDefault(x => x.Tag == tag);
        }
    }
}