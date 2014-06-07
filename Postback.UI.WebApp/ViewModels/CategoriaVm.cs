namespace Postback.UI.WebApp.ViewModels
{
    public class CategoriaVm
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public string CorHexadecimal { get; private set; }

        public CategoriaVm(int id, string descricao, string corHexadecimal)
        {
            Id = id;
            Descricao = descricao;
            CorHexadecimal = corHexadecimal;
        }
    }
}