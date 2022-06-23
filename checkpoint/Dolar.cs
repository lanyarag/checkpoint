
namespace checkpoint
{
    internal class Dolar : Moeda
    {
        public Dolar(string tipo, string nome) : base("$", "dolar")
        {

        }

        public override decimal Conversao(decimal valor)
        {
            decimal cotacaoDolar = 4.5m;
            return valor / cotacaoDolar;
        }
    }
}
