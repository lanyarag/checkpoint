
namespace checkpoint
{
    internal class Iene : Moeda
    {
        public Iene(string tipo, string nome) : base("£", "Iene")
        {

        }

        public override decimal Conversao(decimal valor)
        {
            decimal cotacaoIene = 0.052m;
            return valor / cotacaoIene;
        }
    }
}
