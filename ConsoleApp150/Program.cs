using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor Calc = new Conversor();

            Console.WriteLine("digite valor do dolar hoje: ");
            Calc.ValorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares gostaria de comprar: ");
            Calc.Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Calc.Imposto();
            Calc.ValorFinal();
            Console.WriteLine(Calc);
            Console.ReadLine();
        }
    }
}
