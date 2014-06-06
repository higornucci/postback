using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Postback.Dominio
{
    public class AgrupadorDePostIt
    {

        public static IEnumerable<Grupo> Agrupar(IEnumerable<PostIt> postIts)
        {
            var grupos = new List<Grupo>();

            foreach (var grupoDeCategoria in postIts.GroupBy(x => x.Categoria))
            {
                var categoria = grupoDeCategoria.Key;
                foreach (var grupoDeAssunto in postIts.Where(x => x.Categoria == categoria).GroupBy(x => x.Assunto))
                {
                    var assunto = grupoDeAssunto.Key;

                    var grupo = new Grupo(assunto, postIts.Where(x => x.Assunto == assunto && x.Categoria == categoria));

                    grupos.Add(grupo);
                }
            }

            return grupos;
        }
    }
}