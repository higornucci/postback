namespace Postback.Dominio
{
    public class Tag
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

        public override bool Equals(object obj)
        {
            return ((Tag) obj).Nome == this.Nome;
        }

        public override int GetHashCode()
        {
            return this.Nome.GetHashCode();
        }
    }
}