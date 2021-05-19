using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.00;
        public static double Conversor(double cotacao, double valor)
        {
            double total = cotacao * valor;
            return total + total * Iof / 100.0;            
        }
    }
}
