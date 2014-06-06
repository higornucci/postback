using Postback.Dominio._Base;
using System.Drawing;

namespace Postback.Dominio
{
    public class Categoria : Entidade<Categoria>
    {
        public virtual string Descricao { get; set; }
        public virtual Color Cor { get; set; }
        public virtual string CorHexadecimal { get { return ColorTranslator.ToHtml(Cor); } }

        protected Categoria() { }

        public Categoria(string descricao, string corEmHexadecimal)
        {
            Cor = ColorTranslator.FromHtml(corEmHexadecimal);
            Descricao = descricao;
        }
    }
}