using System.Collections.Generic;
using System.Linq;

namespace Postback.Dominio
{
    public class AgrupadorDePostIt
    {
        public static IEnumerable<Grupo> Agrupar(IEnumerable<PostIt> postIts)
        {
            var grupos = new List<Grupo>();

            foreach (var grupoDeCategoria in postIts.GroupBy(x => x.Categoria))
            {
                var categoria = grupoDeCategoria.Key.Descricao;
                foreach (var grupoDeAssunto in postIts.Where(x => x.Categoria.Descricao == categoria).GroupBy(x => x.Tag))
                {
                    var assunto = grupoDeAssunto.Key.Nome;

                    var grupo = new Grupo(postIts.Where(x => x.Tag.Nome == assunto && x.Categoria.Descricao == categoria));

                    grupos.Add(grupo);
                }
            }

            return grupos;
        }
    }
}