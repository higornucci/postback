using FluentNHibernate.Mapping;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Mapeamentos
{
    public class CategoriaMap : ClassMap<Categoria>
    {
        public CategoriaMap()
        {
            Id(x => x.Id);
            Map(x => x.Descricao);
            Map(x => x.CorHexadecimal);
        }
    }
}
