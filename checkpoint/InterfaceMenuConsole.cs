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
        private Menu menu;
        public InterfaceMenuConsole()
        {
            menu = new Menu();
        }
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
                            this.menu.Conversao(opcao.ToString(), LerValor());
                            Console.WriteLine(this.menu.Tela);
                            break;

                    }
                } while (opcao != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }                       
        }

        private int Menu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("CONVERSOR DE MOEDAS EM REAL\n");
            Console.WriteLine("Informe para qual moeda deseja converter:");
            foreach (var opcao in this.menu.Conversoes)
            {
                Console.WriteLine($"{opcao.Key} - {opcao.Value.Nome}");
            }            
            Console.WriteLine("0 - Sair");
            Console.WriteLine("-----------------------------------");

            return int.Parse(Console.ReadLine() + "");
        }

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
