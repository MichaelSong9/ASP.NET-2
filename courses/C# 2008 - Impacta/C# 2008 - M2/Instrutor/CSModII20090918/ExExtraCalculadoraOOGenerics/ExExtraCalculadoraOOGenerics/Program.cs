using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExExtraCalculadoraOOGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraInteiros calc = new CalculadoraInteiros();
            Console.WriteLine(calc.Somar(4, 3));

            Console.ReadKey(true);
        }
    }
}
