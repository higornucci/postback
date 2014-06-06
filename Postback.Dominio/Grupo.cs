using System.Collections.Generic;
using System.Linq;

namespace Postback.Dominio
{
    public class Grupo
    {
        private IEnumerable<PostIt> PostIts { get; set; }
        private Tag TagDoGrupo { get; set; } 
        public string Assunto { get { return TagDoGrupo.Nome; }}

        public string Cor {
            get
            {
                return PostIts.Any() ? PostIts.FirstOrDefault().Categoria.CorHexadecimal : "#FF0000";
            }
        }

        public Grupo(Tag tagDoGrupo, IEnumerable<PostIt> postIts)
        {
            TagDoGrupo = tagDoGrupo;
            PostIts = postIts;
        }
    }
}