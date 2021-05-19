using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int idade = 32;
            double saldo = 10.35784;
           
            Console.WriteLine("{0} tem {1} anos e tem saldo = {2:F2} reais", nome , idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo = {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo = " + saldo.ToString("f2", CultureInfo.InvariantCulture) + " reais");
           
        }
    }
}
