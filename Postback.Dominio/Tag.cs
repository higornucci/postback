using Postback.Dominio.Helpers;

namespace Postback.Dominio
{
    public class Tag
    {
        public string Nome { get; private set; }

        private Tag() { }

        public Tag(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override bool Equals(object obj)
        {
            return ((Tag)obj).Nome == this.Nome;
        }

        public override int GetHashCode()
        {
            return this.Nome.GetHashCode();
        }

        public string ToHashTag()
        {
            return Nome.ToHashTag();
        }
    }
}