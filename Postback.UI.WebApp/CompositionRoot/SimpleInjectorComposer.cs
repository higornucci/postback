using PostBack.Infra.Persistencia.Repositorios;
using PostBack.Infra.Persistencia.SessionFactory;
using SimpleInjector;
using System.Linq;

namespace Postback.UI.WebApp.CompositionRoot
{
    internal class SimpleInjectorComposer
    {
        private static readonly Container Container = new Container();

        public static Container Compor()
        {
            Container.Register(() => Contexto.Sessao);
            RegistrarAssemblyDe<TagRepositorio>();
            return Container;
        }

        private static void RegistrarAssemblyDe<T>() where T : class
        {
            var assembly = typeof(T).Assembly;
            var classes = assembly.GetTypes().Where(t => t.Name.EndsWith("Repositorio") && t.IsPublic && !t.IsAbstract && t.IsClass && !t.IsGenericType);

            foreach (var @class in classes)
            {
                foreach (var @interface in @class.GetInterfaces())
                    Container.Register(@interface, @class);
            }
        }
    }
}