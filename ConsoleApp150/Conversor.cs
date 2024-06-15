using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp150
{
    internal class Conversor
    {
        public double ValorDolar {  get; set; }
        public double Quantidade {  get; set; }

        public double Imposto()
        {
            return ValorDolar * Quantidade * 0.06;
        }
        public double ValorFinal()
        {
            return Imposto() + (ValorDolar * Quantidade);
        }
        public override string ToString()
        {
            return "Valor a ser pago em reais na compra com 6% de iof: " + ValorFinal().ToString("f2");
        }
    }
}
