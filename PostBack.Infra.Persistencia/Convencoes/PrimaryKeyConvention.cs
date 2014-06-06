using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace PostBack.Infra.Persistencia.Convencoes
{
    public class PrimaryKeyConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.Column("Id");
        }
    }
}