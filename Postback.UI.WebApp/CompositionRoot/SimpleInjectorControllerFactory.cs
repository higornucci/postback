using SimpleInjector;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Postback.UI.WebApp.CompositionRoot
{
    public class SimpleInjectorControllerFactory : DefaultControllerFactory
    {
        private readonly Container _container;

        public SimpleInjectorControllerFactory(Container container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController)_container.GetInstance(controllerType);
        }
    }
}