using System.Collections.Generic;
using System.Linq;

namespace Postback.Dominio
{
    public class Grupo
    {
        private IEnumerable<PostIt> PostIts { get; set; }

        private Tag TagDoGrupo
        {
            get
            {
                return PostIts.Any() ? PostIts.FirstOrDefault().Assunto :
                    new Tag() { Nome = "Sem assunto" };
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
    }
}