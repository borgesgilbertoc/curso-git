﻿using System;

namespace Forech
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine("For normal: " + vect[i]);
            }

            foreach(string obj in vect ) {
                Console.WriteLine("Foreach: " + obj);
            }
        }
    }
}
