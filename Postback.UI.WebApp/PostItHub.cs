using Microsoft.AspNet.SignalR;

namespace Postback.UI.WebApp
{
    public class PostItHub : Hub
    {
        public void EnviarNovoPostIt(PostItModel postIt)
        {
            Clients.All.novoPostIt(postIt.Texto);
        }
    }

    public class PostItModel
    {
        public string Texto { get; set; }
    }
}