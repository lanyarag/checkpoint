using System.Globalization;

namespace checkpoint.Moedas
{
    /// <summary>
    ///  Criamos o objeto moeda com suas caracteristicas(tipo e nome) que serão herdados pelas moedas(dolar,euro,iene,libras)
    /// </summary>

    public abstract class Moeda
    {
        /// <summary>
        /// Definimos as propriedades
        /// </summary>
        /// <permission>
        ///são private set, pois queremos que somente seja possivel alterar o tipo dela na classe que fará herança(ex:dolar)
        ///</permission>

        public string Tipo { get; private set; } 
        public string Nome { get; private set; }//nome da moeda
        public decimal Cotacao { get; private set; }//propriedade que representa a cotação das moedas

        /// <summary>
        /// Possibilita o uso de símbolo e nome da moeda.
        /// </summary>
        private CultureInfo cultureInfo;

        /// <summary>
        /// Criamos o construtor Moeda
        /// </summary>
        /// <param name="cultureCode"  > o código da moeda do país></param>
        /// <param name="cotacao"> cotação do dia </param>
        public Moeda(string cultureCode, decimal cotacao)
        {
            this.cultureInfo = new CultureInfo(cultureCode); //instanciamos essa classe - codigo da moeda (pega-se em sites esse código)
            RegionInfo ri = new RegionInfo(cultureCode); //informações da região informada
            Tipo = ri.CurrencySymbol; //simbolo da moeda padrão
            Nome = ri.CurrencyNativeName; //nome da moeda 
            this.Cotacao = cotacao;
        }

        /// <summary>
        /// formatará o valor que o usuário digitar
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public string FormatarValor(decimal valor)
        {
            return  string.Format(this.cultureInfo.NumberFormat, "{0:0.00}", valor);
        }
        
        public decimal Conversao(decimal valor, Moeda de)
        {
            decimal valorReal = valor * de.Cotacao;
            return valorReal / this.Cotacao;
        }

    }
}


