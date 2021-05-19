using System;
using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = (2 > 4) ? "Verdadeiro" : "Falso";
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double desc = (preco < 20.00) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desc);
            Console.WriteLine("");
        }        
    }
}
