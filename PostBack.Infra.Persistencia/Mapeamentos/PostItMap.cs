using FluentNHibernate.Mapping;
using Postback.Dominio;

namespace PostBack.Infra.Persistencia.Mapeamentos
{
    public class PostItMap : ClassMap<PostIt>
    {
        public PostItMap()
        {
            Id(x => x.Id);
            Map(x => x.Conteudo).Not.Nullable();
            Component(x => x.Tag).ColumnPrefix("Tag_");
            References(x => x.Categoria);
            References(x => x.Quadro);
        }
    }
}
