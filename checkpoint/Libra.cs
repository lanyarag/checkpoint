namespace checkpoint
{
    internal class Libra : Moeda
    {
        public Libra(string tipo, string nome) : base("£", "libra")
        {

        }

        public override decimal Conversao(decimal valor)
        {
            decimal cotacaoLibra = 6.95m;
            return valor / cotacaoLibra;
        }
    }
}
