using System.Collections.Generic;

namespace Postback.Dominio
{
    public interface ISugestaoDeTagRepositorio
    {
        IEnumerable<SugestaoDeTag> ObterTodos();
    }
}