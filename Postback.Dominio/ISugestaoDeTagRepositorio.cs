using System.Collections.Generic;
using Postback.Dominio._Base;

namespace Postback.Dominio
{
    public interface ISugestaoDeTagRepositorio: IRepositorioBase<SugestaoDeTag>
    {
        IEnumerable<SugestaoDeTag> ObterTodos();
        SugestaoDeTag ObterPorTag(Tag tag);
    }
}