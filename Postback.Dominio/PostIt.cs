namespace Postback.Dominio
{
    public class PostIt
    {
        public string Conteudo { get; set; }
        public Tag Assunto { get; set; }
        public Categoria Categoria { get; set; }
        public Quadro Quadro { get; set; }
    }
}