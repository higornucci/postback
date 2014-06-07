using Postback.UI.WebApp.CompositionRoot;
using PostBack.Infra.Persistencia.Convencoes;
using PostBack.Infra.Persistencia.SessionFactory;
using System;
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
            Contexto.SessionFactory = (new ConfiguradorDeSessionFactory()).CriarSessionFactory(ServidorDePublicacao.Producao, false, true);
        }

        private static void ConfigurarInjecaoDeDependencia()
        {
            var container = SimpleInjectorComposer.Compor();
            ControllerBuilder.Current.SetControllerFactory(new SimpleInjectorControllerFactory(container));
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
}
