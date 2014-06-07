using Postback.Dominio._Base;

namespace Postback.Dominio
{
    public class PostIt : Entidade<PostIt>
    {
        public virtual string Conteudo { get; protected set; }
        public virtual Tag Tag { get; set; }
        public virtual Categoria Categoria { get; protected set; }
        public virtual Quadro Quadro { get; protected set; }

        protected PostIt() { }

        public PostIt(string conteudo, Quadro quadro, Categoria categoria, Tag tag)
        {
            Conteudo = conteudo;
            Quadro = quadro;
            Categoria = categoria;
            Tag = tag;
        }
    }
}