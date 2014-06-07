using Microsoft.AspNet.SignalR;

namespace Postback.UI.WebApp
{
    public class PostItHub : Hub
    {
        public void EnviarNovoPostIt(string conteudo, string tagNome, int categoriaId, string categoriaCor)
        {
            Clients.All.novoPostIt(conteudo, tagNome, categoriaId, categoriaCor);
        }
    }
}