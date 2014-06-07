using Microsoft.AspNet.SignalR;
using Postback.UI.WebApp.Extensions;

namespace Postback.UI.WebApp
{
    public class PostItHub : Hub
    {
        public void EnviarNovoPostIt(string conteudo, string tagNome, int categoriaId, string categoriaCor)
        {
            Clients.All.novoPostIt(conteudo, tagNome, tagNome.ToHashTag(), categoriaId, categoriaCor);
        }
    }
}