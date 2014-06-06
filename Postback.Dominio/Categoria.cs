using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace Postback.Dominio
{
    public class Categoria
    {
        private string  Descricao { get; set; }
        public Color Cor { get; set; }
        public string CorHexadecimal { get { return ColorTranslator.ToHtml(Cor); } }

        public Categoria(string descricao, string corEmHexadecimal)
        {
            Cor = ColorTranslator.FromHtml(corEmHexadecimal);
            Descricao = descricao;
        }


        public static IEnumerable ObterCategorias(IEnumerable<PostIt> postIts)
        {
            return postIts.GroupBy(x => x.Categoria).Select(x => x.Key);
        }
    }
}