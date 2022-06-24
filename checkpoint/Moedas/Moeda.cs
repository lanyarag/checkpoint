using System.Globalization;

namespace checkpoint.Moedas
{
    public abstract class Moeda
    {
        public string Tipo { get; private set; }
        public string Nome { get; private set; }
        public decimal Cotacao { get; private set; }

        private CultureInfo cultureInfo;

        public Moeda(string cultureCode, decimal cotacao)
        {
            this.cultureInfo = new CultureInfo(cultureCode); //codigo da moeda
            RegionInfo ri = new RegionInfo(this.cultureInfo.LCID); //informações da região
            Tipo = ri.CurrencySymbol; //simbolo da moeda
            Nome = ri.CurrencyNativeName; //nome da moeda 
            this.Cotacao = cotacao;
        }

        public string FormatarValor(decimal valor) 
        {
            return valor.ToString(this.cultureInfo.NumberFormat);
        }

        public decimal Conversao(decimal valor)
        {
            return valor * this.Cotacao;
        }

    }
}


