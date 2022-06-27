namespace checkpoint.Moedas
{
    public class Menu
    {
        public Dictionary<string, Moeda> Conversoes { get; private set; } 
        
        
        /// <summary>
        /// Propriedade tela exibe o menu na tela do usuário
        /// </summary>
        public string Tela { get; set; } 

        public Menu()
        {            
            Moeda dolar = new Dolar();
            Moeda euro = new Euro();
            Moeda iene = new Iene();
            Moeda libra = new Libra();
            Moeda real = new Real();

            this.Conversoes = new Dictionary<string, Moeda>();
            this.Conversoes.Add("1", dolar);
            this.Conversoes.Add("2", euro);
            this.Conversoes.Add("3", iene);
            this.Conversoes.Add("4", libra);
            this.Conversoes.Add("5", real);

        }

        /// <summary>
        /// Chamada do método de conversão na Classe Interface, que é a comunicação direta com o usuário. Verifica se a key informada pelo usuário existe. if true = exibe o cálculo de conversão da classe (moeda). Caso não:ele exibirá na tela o calculo de Conversão da classe (moeda)
        /// </summary>
        /// <param name="operacaoDe"></param>
        /// <param name="operacaoPara"></param>
        /// <param name="valor"></param>
        /// <exception cref="Exception">Exceção de opção não encotrada nos escopos ></exception>
        public void Conversao(string operacaoDe, string operacaoPara, decimal valor)
        {
            if(!this.Conversoes.ContainsKey(operacaoPara))
            {
                throw new Exception("Opção não encontrada");
            }
           this.Tela = (" " + this.Conversoes[operacaoPara].Tipo + " " + this.Conversoes[operacaoPara].FormatarValor(this.Conversoes[operacaoPara].Conversao(valor, this.Conversoes[operacaoDe])));

        }    

    }
}
