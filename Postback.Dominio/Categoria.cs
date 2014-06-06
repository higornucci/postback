using System;
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

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Descricao.Equals(((Categoria) obj).Descricao);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Descricao.GetHashCode();
        }
    }
}