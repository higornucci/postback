using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using PostBack.Infra.Persistencia.Convencoes;
using System.Reflection;

namespace PostBack.Infra.Persistencia.SessionFactory
{
    public class ConfiguradorDeSessionFactory
    {
        public ISessionFactory CriarSessionFactory(ServidorDePublicacao servidorDePublicacao, bool exibirSql = false, bool criarBd = false)
        {
            var nomeStringDeConexao = "SqlServer" + (servidorDePublicacao == ServidorDePublicacao.Producao ? string.Empty : "-" + servidorDePublicacao);

            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey(nomeStringDeConexao)))
                .CurrentSessionContext("web")
                .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())
                    .Conventions.Add(AutoImport.Never())
                    .Conventions.Add<PrimaryKeyConvention>()
                    .Conventions.Add<EnumConvention>()
                    .Conventions.Add<CustomForeignKeyConvention>())
                    .ExposeConfiguration(config =>
                    {
                        new SchemaExport(config).Drop(exibirSql, criarBd);
                        new SchemaExport(config).Create(exibirSql, criarBd);
                    })
                .BuildSessionFactory();
        }
    }
}