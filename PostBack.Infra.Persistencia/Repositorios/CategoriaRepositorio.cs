using NHibernate;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Repositorios
{
    public class CategoriaRepositorio: RepositorioBase<Categoria>, ICategoriaRepositorio
    {
        public CategoriaRepositorio(ISession sessao) : base(sessao) {}
    }
}