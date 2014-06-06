namespace Postback.Dominio._Base
{
    public interface IRepositorioBase<T> where T : Entidade<T>
    {
        T ObterPor(int id);
        void Adicionar(T entidade);
        void Remover(T entidade);
    }
}