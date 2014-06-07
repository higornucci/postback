using Postback.Dominio._Base;
using System.Drawing;

namespace Postback.Dominio
{
    public class Categoria : Entidade<Categoria>
    {
        public virtual string Descricao { get; set; }
        public virtual string CorHexadecimal { get ; set; }

        protected Categoria() { }

        public Categoria(string descricao, string corEmHexadecimal)
        {
            CorHexadecimal = corEmHexadecimal;
            Descricao = descricao;
        }
    }
}