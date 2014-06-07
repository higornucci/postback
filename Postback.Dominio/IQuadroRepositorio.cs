using Postback.Dominio._Base;

namespace Postback.Dominio
{
    public interface IQuadroRepositorio : IRepositorioBase<Quadro>
    {
        Quadro ObterAtivo();
    }
}
