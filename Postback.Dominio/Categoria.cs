using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace Postback.Dominio
{
    public class Categoria
    {
        public string  Descricao { get; set; }
        public Color Cor { get; set; }
        public string CorHexadecimal { get { return ColorTranslator.ToHtml(Cor); } }

        public Categoria(string descricao, string corEmHexadecimal)
        {
            Cor = ColorTranslator.FromHtml(corEmHexadecimal);
            Descricao = descricao;
        }

        public override bool Equals(object obj)
        {
            var other = (Categoria) obj;
            return other.Descricao == Descricao;
        }

        public override int GetHashCode()
        {
            return Descricao.GetHashCode();
        }
    }
}