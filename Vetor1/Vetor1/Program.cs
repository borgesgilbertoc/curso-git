using System;
using System.Globalization;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade do vetor: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um valor: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("Média: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            


        }
    }
}
