using System.Collections.Generic;
using System.Linq;

namespace Postback.Dominio
{
    public class Grupo
    {
        public IEnumerable<PostIt> PostIts { get; set; }

        private Tag TagDoGrupo
        {
            get
            {
                return PostIts.Any() ? PostIts.FirstOrDefault().Tag :
                    new Tag("Sem assunto");
            }
        }

        public string Assunto { get { return TagDoGrupo.Nome; } }

        public string Cor
        {
            get
            {
                return PostIts.Any() ? PostIts.FirstOrDefault().Categoria.CorHexadecimal : "#FF0000";
            }
        }

        public Categoria Categoria
        {
            get
            {
                return PostIts.Any() ? PostIts.FirstOrDefault().Categoria : null;
            }
        }

        public Grupo(IEnumerable<PostIt> postIts)
        {
            PostIts = postIts;
        }

        public override string ToString()
        {
            return Assunto;
        }
    }
}