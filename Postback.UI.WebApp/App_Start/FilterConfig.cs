using Postback.UI.WebApp.Filters;
using System.Web.Mvc;

namespace Postback.UI.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new UnitOfWorkAttribute());
        }
    }
}
