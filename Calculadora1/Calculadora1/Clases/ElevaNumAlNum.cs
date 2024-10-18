using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Calculadora1.Clases
{
    internal class ElevaNumAlNum
    {
        public static double ElevarNumAlNum(double num1, double num2)
        {
            double total = 0;
            int i = 0;

            while (i <= num2)
           
            {
                total = num1 * num1;
                i++;

            }return total;
            
            
 
        }

    }
}
