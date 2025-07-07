using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    public class Projektnavn
    {
        public double Add(double a, double b)

        {
            return a + b;
        }


        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Du kan ikke dividere med 0.");
            }

            return a / b;
        }

        public double Exponentiation(double a, double b)
        {
            return Math.Pow(a, b); // Beregner a opløftet til b
        }
        public double SquareRoot(double a)
        {
            return Math.Sqrt(a); 
        }

        public double Percentage(double a, double b)
        {
            return (a * b) / 100;
        }
    }
}