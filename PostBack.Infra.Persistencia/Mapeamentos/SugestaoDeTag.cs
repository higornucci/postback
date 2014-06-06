using FluentNHibernate.Mapping;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Mapeamentos
{
    public class SugestaoDeTagMap : ClassMap<SugestaoDeTag>
    {
        public SugestaoDeTagMap()
        {
            Id(x => x.Id);
            Component(x => x.Tag).ColumnPrefix("Tag_");
        }
    }
}
