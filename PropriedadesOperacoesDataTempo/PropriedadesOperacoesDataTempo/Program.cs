using System;

namespace PropriedadesOperacoesDataTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime d2 = d.AddDays(2);

            TimeSpan t = d2.Subtract(d);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(t);

            TimeSpan t1 = TimeSpan.MaxValue;

            TimeSpan t2 = TimeSpan.MinValue;

            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(1, 30, 10 );

            Console.WriteLine(t4);
            Console.WriteLine("Days: " + t4.Days);

            TimeSpan t5 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t4.Add(t5);
            TimeSpan dif = t4.Subtract(t5);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
