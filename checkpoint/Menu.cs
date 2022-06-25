namespace checkpoint.Moedas
{
    public class Menu
    {
        public Dictionary<NomeMoeda, Moeda> Conversoes { get; private set; } 
        public string Tela { get; set; } //propriedade que mostrará na tela do usuário
        
        public enum NomeMoeda
        {
            DOLAR,
            EURO,
            IENE,
            LIBRA
        }

        public Menu()
        {
            Moeda dolar = new Dolar();
            Moeda euro = new Euro();
            Moeda iene = new Iene();
            Moeda libra = new Libra();

            this.Conversoes = new Dictionary<NomeMoeda, Moeda>();
            this.Conversoes.Add(NomeMoeda.DOLAR, dolar);
            this.Conversoes.Add(NomeMoeda.EURO, euro);
            this.Conversoes.Add(NomeMoeda.IENE, iene);
            this.Conversoes.Add(NomeMoeda.LIBRA, libra);
        }

        //Metodo que chamará o metodo de conversão
        //Primeramente, ele verificará se a Key informada pelo usuário existe, se existir ele exibirá na tela o calculo de Conversão da classe (moeda)
        //se não existir, vai informar que a opão não foi encontrada
        //Esse metodo será chamado na Classe Interface que é a comunicação direta com o usuário 
        public void Conversao(string operacao,decimal valor)
        {
            NomeMoeda nomeMoeda;

            try
            {
                nomeMoeda = (NomeMoeda)Enum.Parse(typeof(NomeMoeda), operacao, true);

                this.Tela = " " + this.Conversoes[nomeMoeda].Tipo + " " + this.Conversoes[nomeMoeda].FormatarValor(this.Conversoes[nomeMoeda].Conversao(valor));

            }
            catch (ArgumentException erro)
            {
                Console.WriteLine("Opção não encontrada");
            }
            
            
        }
        //public void Conversao(NomeMoeda nomeMoeda, decimal valor)
        //{
        //      //this.Tela = " " + this.Conversoes[nomeMoeda].Tipo
        //      //  + " "
        //      //  + this.Conversoes[nomeMoeda].FormatarValor(this.Conversoes[nomeMoeda].Conversao(valor));
        //}

    }
}
