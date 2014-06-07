namespace Postback.Dominio
{
    public class Tag
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

        public override bool Equals(object obj)
        {
            return ((Tag)obj).Nome == Nome;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}