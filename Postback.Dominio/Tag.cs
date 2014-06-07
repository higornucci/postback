using Postback.Dominio._Base;

namespace Postback.Dominio
{
    public class Tag : ObjetoDeValor<Tag>
    {
        public string Nome { get; private set; }

        private Tag() { }

        public Tag(string nome)
        {
            Nome = nome.ToLower();
        }

        public override string ToString()
        {
            return Nome;
        }

        protected override bool TodosOsAtributosSaoIguais(Tag outraTag)
        {
            return Nome.Equals(outraTag.Nome);
        }

        protected override int ObterHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}