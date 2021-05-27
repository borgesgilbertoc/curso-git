using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0 && n1 != 0)            
                   Console.WriteLine("PAR");          
            else if (n1 == 0)
                Console.WriteLine("ZERO");           
            else
                Console.WriteLine("IMPAR");       

        }
    }
}
