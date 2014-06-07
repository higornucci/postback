using Postback.Dominio._Base;

namespace Postback.Dominio
{
    public class SugestaoDeTag : Entidade<SugestaoDeTag>
    {
        public virtual Tag Tag { get; protected set; }

        protected SugestaoDeTag() { }

        public SugestaoDeTag(Tag tag)
        {
            Tag = tag;
        }
    }
}