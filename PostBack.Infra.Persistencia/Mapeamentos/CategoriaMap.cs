using FluentNHibernate.Mapping;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Mapeamentos
{
    public class CategoriaMap : ClassMap<Categoria>
    {
        public CategoriaMap()
        {
            Id(c => c.Id);
            Map(c => c.Descricao);
        }
    }
}
