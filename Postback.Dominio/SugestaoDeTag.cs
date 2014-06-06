using Postback.Dominio._Base;

namespace Postback.Dominio
{
    public class SugestaoDeTag : Entidade<SugestaoDeTag>
    {
        public virtual Tag Tag { get; set; }
    }
}