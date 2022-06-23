namespace checkpoint
{
    public abstract class Moeda
    {
        public string Tipo { get; private set; }
        public string Nome { get; private set; }

        public Moeda(string tipo, string nome)
        {
            this.Tipo = tipo;
            this.Nome = nome;
        }

        public abstract decimal Conversao(decimal valor);

    }
}

        
//        

//        public void ConversaoEuro(double valorEmReais, double cotacaoEuro)
//        {

//        }
        

//    }
//}
