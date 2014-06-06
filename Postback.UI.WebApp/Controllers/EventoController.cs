using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class EventoController : Controller
    {
        //
        // GET: /Evento/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Criar()
        {
            return View();
        }
	}
}