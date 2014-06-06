using System.Collections.Generic;

namespace Postback.Dominio
{
    public class Quadro
    {
        public  IEnumerable<Categoria> Categorias;
        public string Descricao { get; set; }
    }
}