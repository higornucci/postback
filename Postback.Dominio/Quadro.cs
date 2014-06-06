using Postback.Dominio._Base;
using System.Collections.Generic;

namespace Postback.Dominio
{
    public class Quadro : Entidade<Quadro>
    {
        public IEnumerable<Categoria> Categorias;
        public string Descricao { get; set; }
    }
}