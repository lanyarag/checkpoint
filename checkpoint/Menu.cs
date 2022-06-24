namespace checkpoint.Moedas
{
    public class Menu
    {
        public Dictionary<string, Moeda> Conversoes { get; private set; } 
        public string Tela { get; set; }
     

        public Menu()
        {
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="operacao"></param>
        /// <param name="valor"></param>
        /// <exception cref="Exception"></exception>
        public void Conversao(string operacao,decimal valor)
        {
            if(!this.Conversoes.ContainsKey(operacao))
            {
                throw new Exception("Opção não encontrada");
            }
           this.Tela = (" " + this.Conversoes[operacao].Tipo + " " + this.Conversoes[operacao].FormatarValor(this.Conversoes[operacao].Conversao(valor)));
            
        }    

    }
}
