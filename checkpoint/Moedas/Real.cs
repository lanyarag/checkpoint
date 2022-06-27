using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint.Moedas
{
    public class Real : Moeda
    {
        public Real() : base("pt-BR", 1m)//código do país e cotação da moeda
        {
        }
    }
}
