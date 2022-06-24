using checkpoint.Moedas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint
{
    public class InterfaceMenuConsole
    {
        private Menu menu; //implementamos essa classe para conseguirmos manipular o menu e interagir com o usuário
        public InterfaceMenuConsole()
        {
            menu = new Menu(); 
        }
        //Operações que serão realizadas quando o usuário digitar a opção desejada        
        public void MenuIniciar()
        {
            int opcao; 
            try
            {
                do
                {
                    opcao = Menu();
                    switch (opcao)
                    {
                        case 0:
                            break;
                        default:
                            this.menu.Conversao(opcao.ToString(), LerValor()); //criei o metodo LerValor, para somente ler o valor que o usuário deseja converter
                            Console.WriteLine(this.menu.Tela);//após realizar o metodo conversão, irá exibir para o usuário o resultado
                            break;

                    }
                } while (opcao != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }                       
        }

        //criamos o Menu para ser exibido no metodo acima "Menu Iniciar"
        private int Menu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("CONVERSOR DE MOEDAS EM REAL\n");
            Console.WriteLine("Informe para qual moeda deseja converter:");
            foreach (var opcao in this.menu.Conversoes) //imprimirá todos os itens do dicionário e já com a simbologia e nome da moeda (definimos isso na calsse Moeda, com o CultureInfo)
            {
                Console.WriteLine($"{opcao.Key} - {opcao.Value.Nome}");
            }            
            Console.WriteLine("0 - Sair");
            Console.WriteLine("-----------------------------------");

            return int.Parse(Console.ReadLine() + "");
        }

        //Metodo para ler o que o usuário digitar, e se caso seja digitado qualquer coisa diferente de número, ficará pedindo para o usuário digitar um número
        //obs:precisa digitar com virgula(ex: 10,50) e não 10.50 quando for informar o valor no menu
        private decimal LerValor()
        {
            Console.WriteLine("Digite o número que deseja converter: ");
            decimal retorno = 0;
            while (!decimal.TryParse(Console.ReadLine(), out retorno))
            {
                Console.WriteLine("Você deve digitar um número");
            }
            return retorno;
        }
    }
}
