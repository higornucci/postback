using Postback.Dominio._Base;

namespace Postback.Dominio
{
    public class PostIt : Entidade<PostIt>
    {
        public virtual string Conteudo { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Quadro Quadro { get; set; }
    }
}