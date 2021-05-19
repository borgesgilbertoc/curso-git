using System;
using System.Collections.Generic;

namespace Listas1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("Maria");
            list1.Add("Alex");
            list1.Add("Bob");
            list1.Add("Ana");
            list1.Insert(2, "Marco");

            Console.Write("Digite um nome para adicionar na lista: ");
            string teste = Console.ReadLine();
            list1.Add(teste);
            
            foreach(string obj in list1)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: "+list1.Count);
            Console.WriteLine("--------------------------");

            string s1 = list1.Find(x => x[0] == 'A');
            
            Console.WriteLine("First A: " + s1);
            Console.WriteLine("--------------------------");

            string s2 = list1.FindLast(x => x[0] == 'A');

            Console.WriteLine("FindLast A: " + s2);
            Console.WriteLine("--------------------------");

            int n1 = list1.FindIndex(x => x[0] == 'A');

            Console.WriteLine("First pos A: " + n1);
            Console.WriteLine("--------------------------");
            
            int n2 = list1.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("FindLastIndex post A: " + n2);
            Console.WriteLine("--------------------------");

            List<string> list2 = list1.FindAll(x => x.Length == 5);                

            foreach(string obj in list2)
            {
                Console.WriteLine("list 2 Length 5: " + obj);
            }
            Console.WriteLine("--------------------------");

            list1.Remove("Alex");
            //list.RemoveAt(2);
            //list.RemoveRange(2, 2);
            foreach (string obj in list1)
            {
                Console.WriteLine("list remove alex: " + obj);
            }
            Console.WriteLine("--------------------------");
            list1.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list1)
            {
                Console.WriteLine("list começa M: " + obj);
            }
            Console.WriteLine("--------------------------");


        }
    }
}
