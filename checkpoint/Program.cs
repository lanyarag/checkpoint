using System;
using System.Globalization;

namespace checkpoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ao abrir a aplicação solicite o valor em real(R$) que o usuário deseja converter
            Console.WriteLine("Qual o valor em reais que você deseja converter?");
            double ValorEmReal = double.Parse(Console.ReadLine());


            //Após leitura do valor a ser convertido, exibir um menu para selecionar para qual moeda o usuário deseja converter: dólar($), euro(€), iene(¥) ou libra esterlina(£).

            //chamar método ConversaoDolar

            //uso de Dictionary e utilize - o para armazenar o valor de cada moeda que será usado na conversão.


        }
    }
}