using System.Collections.Generic;
using Postback.Dominio;

namespace Postback.UI.WebApp.ViewModels
{
    public class QuadroAtivoVm
    {
        public string QuadroDescricao { get; set; }
        public IEnumerable<Grupo> Grupos { get; set; }
    }
}