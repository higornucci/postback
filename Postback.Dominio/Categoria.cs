using System.Diagnostics;
using System.Drawing;

namespace Postback.Dominio
{
    public class Categoria
    {
        public string  Descricao { get; set; }
        public Color Cor { get; set; }

        public Categoria(string descricao, string corEmHexadecimal)
        {
            Cor = ColorTranslator.FromHtml(corEmHexadecimal);
            Descricao = descricao;
        }


    }
}