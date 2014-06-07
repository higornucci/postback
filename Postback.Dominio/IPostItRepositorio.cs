using Postback.Dominio._Base;
using System.Collections.Generic;

namespace Postback.Dominio
{
    public interface IPostItRepositorio : IRepositorioBase<PostIt>
    {
        IEnumerable<PostIt> ObterPorQuadro(Quadro quadro);
    }
}