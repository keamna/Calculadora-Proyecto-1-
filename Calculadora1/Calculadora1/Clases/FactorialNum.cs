using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1.Clases
{
    internal class FactorialNum
    { 
        public static double FactorialNumerico(double num1, double num2)
        {
            double factorial = 1;
            for (int i = 1; i <= num1; i++) { 
                
                factorial *= i;
            }

            return factorial;
        }
    }
}
