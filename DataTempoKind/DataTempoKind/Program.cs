using System;

namespace DataTempoKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Kind);
            Console.WriteLine(d1.ToLocalTime());
            Console.WriteLine(d1.ToUniversalTime());
            Console.WriteLine("");
            Console.WriteLine(d2);
            Console.WriteLine(d2.Kind);
            Console.WriteLine(d2.ToLocalTime());
            Console.WriteLine(d2.ToUniversalTime());
            Console.WriteLine("");
            Console.WriteLine(d3);
            Console.WriteLine(d3.Kind);
            Console.WriteLine(d3.ToLocalTime());
            Console.WriteLine(d3.ToUniversalTime());

            //ISO 8610
            //yyyy-MM-ddTHH:mm:ssZ

            Console.WriteLine("-------------------");
            DateTime da1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime da2 = DateTime.Parse("2000-08-15T13:05:58Z");
            Console.WriteLine(da1);
            Console.WriteLine(da1.Kind);
            Console.WriteLine(da1.ToLocalTime());
            Console.WriteLine(da1.ToUniversalTime());
            Console.WriteLine("");
            Console.WriteLine(da2);
            Console.WriteLine(da2.Kind);
            Console.WriteLine(da2.ToLocalTime());
            Console.WriteLine(da2.ToUniversalTime());


        }
    }
}
