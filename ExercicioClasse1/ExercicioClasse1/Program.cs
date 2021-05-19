﻿using System;
using System.Globalization;

namespace ExercicioClasse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f.AumentarSalario(percentual);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);

        }
    }
}
