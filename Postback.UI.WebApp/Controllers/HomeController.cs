using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", Request.Browser.IsMobileDevice ? "PostIt" : "Quadro");
        }
    }
}