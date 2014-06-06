using FluentNHibernate.Mapping;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Mapeamentos
{
    public class TagMap : ComponentMap<Tag>
    {
        public TagMap()
        {
            Map(x => x.Nome);
        }
    }
}
