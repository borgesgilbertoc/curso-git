using System;
using System.Globalization;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa");
            string quartos = Console.ReadLine();
            Console.WriteLine("Preço de um produto");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Seu último nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine( preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(nome1);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
