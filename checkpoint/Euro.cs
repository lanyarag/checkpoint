namespace checkpoint
{
    internal class Euro : Moeda
    {
        public Euro(string tipo, string nome) : base("€", "Euro")
        {
        }

        public override decimal Conversao(decimal valor)
        {
            decimal cotacaoEuro = 6.20m;
            return valor / cotacaoEuro;
        }
    }
}
