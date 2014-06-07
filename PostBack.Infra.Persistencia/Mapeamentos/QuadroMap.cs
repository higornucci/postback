using FluentNHibernate.Mapping;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Mapeamentos
{
    public class QuadroMap : ClassMap<Quadro>
    {
        public QuadroMap()
        {
            Id(x => x.Id);
            Map(x => x.Descricao).Not.Nullable();
            Map(x => x.Ativo).Not.Nullable();
            HasManyToMany(x => x.Categorias).Cascade.AllDeleteOrphan();
        }
    }
}
