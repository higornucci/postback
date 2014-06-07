using Postback.Dominio._Base;
using System.Collections.Generic;

namespace Postback.Dominio
{
    public class Quadro : Entidade<Quadro>
    {
        public virtual string Descricao { get; set; }
        public virtual bool Ativo { get; set; }
        public virtual IEnumerable<Categoria> Categorias { get; set; }
    }
}