using SimpleInjector;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Postback.UI.WebApp.Controllers
{
    public class WebAppControllerFactory : DefaultControllerFactory
    {
        private readonly Container _container;

        public WebAppControllerFactory(Container container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController)_container.GetInstance(controllerType);
        }
    }
}