using System;
using System.Globalization;

namespace whille
{
    class Program
    {        
        static void Main(string[] args)
        {

            Console.Write("Quantos números quer?");
            int n = int.Parse(Console.ReadLine());

            double x = 0.0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite o {0}º número: ", i);
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x += valor;
            }
            Console.WriteLine("Total: " + x.ToString("F3", CultureInfo.InvariantCulture));

            
            // while (x >= 0.0) 
            // {
            //    x = raiz();
            // }            

        }
        static double raiz()
        {
            Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n1 >= 0)
            {
                double raiz = Math.Sqrt(n1);
                Console.WriteLine("Raiz quadrada : " + raiz.ToString("F3", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Número negativo!");
            }
            return n1;
        }


    }
}
