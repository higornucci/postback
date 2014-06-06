using NHibernate;
using NHibernate.Linq;
using Postback.Dominio._Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public abstract class RepositorioBase<TEntidade> where TEntidade : Entidade<TEntidade>
    {
        protected ISession Sessao { get; private set; }

        protected RepositorioBase(ISession sessao)
        {
            if (sessao == null) throw new ArgumentNullException("sessao");
            Sessao = sessao;
        }

        protected IQueryable<TEntidade> All()
        {
            return Sessao.Query<TEntidade>();
        }

        protected IEnumerable<TEntidade> Enumerar()
        {
            return Sessao.CreateCriteria(typeof(TEntidade)).List<TEntidade>();
        }

        public TEntidade ObterPor(int id)
        {
            return Sessao.Get<TEntidade>(id);
        }

        public void Adicionar(TEntidade entidade)
        {
            Sessao.Save(entidade);
        }

        public void Remover(TEntidade entidade)
        {
            Sessao.Delete(entidade);
        }
    }
}