using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    public class Projektnavn
    {
        public double Addition(double a, double b)

        {
            return a + b;
        }


        public double Subtraktions(double a, double b)
        {
            return a - b;
        }

        public double Multiplikations(double a, double b)
        {
            return a * b;
        }

        public double Divisions(double a, double b)
        {
            if (b > 0 && a > b)
            {
                return a / b;
            }
        }
    }
}