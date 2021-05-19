using System;
using System.Globalization;

namespace Veto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Preco = preco };
                sum += vect[i].Preco;
            }
            double avg = sum / n;
            Console.WriteLine("Preço médio: " + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
