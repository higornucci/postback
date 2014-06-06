using Postback.UI.WebApp.Controllers;
using PostBack.Infra.Persistencia.Convencoes;
using PostBack.Infra.Persistencia.SessionFactory;
using PostBack.Infra.Repositorios;
using SimpleInjector;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Postback.UI.WebApp
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigurarOrm();
            ConfigurarInjecaoDeDependencia();
        }

        private static void ConfigurarOrm()
        {
            Contexto.SessionFactory = (new ConfiguradorDeSessionFactory()).CriarSessionFactory(ServidorDePublicacao.Producao);
        }

        private static void ConfigurarInjecaoDeDependencia()
        {
            var container = SimpleInjectorComposer.Compor();
            ControllerBuilder.Current.SetControllerFactory(new WebAppControllerFactory(container));
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Contexto.LigarContextoDaSessaoNh();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Contexto.DesligarContextoDaSessaoNh();
        }
    }

    internal class SimpleInjectorComposer
    {
        private static readonly Container Container = new Container();

        public static Container Compor()
        {
            RegistrarAssemblyDe<TagRepositorio>();
            return Container;
        }

        private static void RegistrarAssemblyDe<T>() where T : class
        {
            var assembly = typeof(T).Assembly;
            var classes = assembly.GetTypes().Where(t => t.IsPublic && !t.IsAbstract && t.IsClass && !t.IsGenericType);

            foreach (var @class in classes)
            {
                foreach (var @interface in @class.GetInterfaces())
                    Container.Register(@interface, @class);
            }
        }
    }
}
