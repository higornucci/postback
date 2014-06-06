using PostBack.Infra.Persistencia.SessionFactory;
using System;
using System.Web.Mvc;

namespace Postback.UI.WebApp.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class UnitOfWorkAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Contexto.Sessao == null) return;
            Contexto.Sessao.BeginTransaction();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (Contexto.Sessao == null) return;
            var transacao = Contexto.Sessao.Transaction;

            if (transacao == null || !transacao.IsActive) return;

            if (filterContext.Exception == null)
                transacao.Commit();
            else
                transacao.Rollback();
        }
    }
}
