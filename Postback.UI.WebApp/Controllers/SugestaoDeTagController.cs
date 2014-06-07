using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Controllers
{
    public class SugestaoDeTagController : Controller
    {
        public JsonResult Sugerir(string term)
        {
            var lista = new List<object>
            {
                new {id = "Tag 1", label = "Tag 1", value = "Tag 1"},
                new {id = "Tag 2", label = "Tag 2", value = "Tag 2"},
                new {id = "Tag 3", label = "Tag 3", value = "Tag 3"}
            };

            return Json(lista, JsonRequestBehavior.AllowGet);
        }
	}
}