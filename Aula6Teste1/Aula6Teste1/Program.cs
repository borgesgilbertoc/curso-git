using System;

namespace Aula6Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

            Nullable<double> a = null;
            double? b = null;
            b = 10.00;
            Console.WriteLine(a + b);
            Console.WriteLine();
            Console.WriteLine("GetValueOrDefault: ");
            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());
            Console.WriteLine();
            Console.WriteLine("HasValue: ");
            Console.WriteLine(a.HasValue);
            Console.WriteLine(b.HasValue);
            Console.WriteLine();
            Console.WriteLine("Value: ");
            if (a.HasValue)
              Console.WriteLine(a.Value);
            else
              Console.WriteLine("Y is null");
            Console.WriteLine(b.Value);
            Console.WriteLine();

            double c = a ?? 5.0;
            double d = b ?? 5.0;
            Console.WriteLine("Valor c e d");
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine();

        }
    }
}
