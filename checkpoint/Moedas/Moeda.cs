using System.Globalization;

namespace checkpoint.Moedas
{
    //Criamos o objeto moeda com suas caracteristicas(tipo e nome) que sera herdada pelas moedas(dolar,euro,iene,libras)
    public abstract class Moeda
    {
        //Definimos as propriedades
        //são private set, pois queremos que somente seja possivel alterar o tipo dela na classe que fará herança (ex:dolar)
        public string Tipo { get; private set; } 
        public string Nome { get; private set; }//nome da moeda
        public decimal Cotacao { get; private set; }//propriedade que representa a cotação das moedas

        private CultureInfo cultureInfo; //implementamos essa classe, para que possamos utilizar o recurso que exibirá o nome e o simboli da moeda

        //Criamos o contrutor Moeda, que recebeu como parametro o código da moeda do país, e a cotação do dia. (as classes moedas também heradaram essas informações especificas)
        public Moeda(string cultureCode, decimal cotacao)
        {
            this.cultureInfo = new CultureInfo(cultureCode); //instanciamos essa classe - codigo da moeda (pega-se em sites esse código)
            RegionInfo ri = new RegionInfo(this.cultureInfo.LCID); //informações da região informada
            Tipo = ri.CurrencySymbol; //simbolo da moeda padrão
            Nome = ri.CurrencyNativeName; //nome da moeda 
            this.Cotacao = cotacao;
        }

        //formatara o valor que o usuário digitar
        public string FormatarValor(decimal valor)
        {
            return valor.ToString(this.cultureInfo.NumberFormat);
        }
        //realizará o calculo de conversão sempre que for chamado
        public decimal Conversao(decimal valor)
        {
            return valor * this.Cotacao;
        }

    }
}


