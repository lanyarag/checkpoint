namespace checkpoint.Moedas
{
    public abstract class Moeda
    {
        public string Tipo { get; private set; }
        public string Nome { get; private set; }

        public Moeda(string tipo, string nome)
        {
            Tipo = tipo;
            Nome = nome;
        }

        public abstract decimal Conversao(decimal valor);

    }
}


