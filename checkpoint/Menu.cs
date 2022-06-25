namespace checkpoint.Moedas
{
    public class Menu
    {
        public Dictionary<string, Moeda> Conversoes { get; private set; } 
        public string Tela { get; set; } //propriedade que mostrará na tela do usuário

        Moeda moeda_base;

        public Menu()
        {
            moeda_base = new Real();
            Moeda dolar = new Dolar();
            Moeda euro = new Euro();
            Moeda iene = new Iene();
            Moeda libra = new Libra();

            this.Conversoes = new Dictionary<string, Moeda>();
            this.Conversoes.Add("1", dolar);
            this.Conversoes.Add("2", euro);
            this.Conversoes.Add("3", iene);
            this.Conversoes.Add("4", libra);
        }

        //Metodo que chamará o metodo de conversão
        //Primeramente, ele verificará se a Key informada pelo usuário existe, se existir ele exibirá na tela o calculo de Conversão da classe (moeda)
        //se não existir, vai informar que a opão não foi encontrada
        //Esse metodo será chamado na Classe Interface que é a comunicação direta com o usuário 
        public void Conversao(string operacaoPara, decimal valor)
        {
            if(!this.Conversoes.ContainsKey(operacaoPara))
            {
                throw new Exception("Opção não encontrada");
            }
           this.Tela = (" " + this.Conversoes[operacaoPara].Tipo + " " + this.Conversoes[operacaoPara].FormatarValor(this.Conversoes[operacaoPara].Conversao(valor, this.moeda_base)));
            
        }    

    }
}
