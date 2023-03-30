using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath211E
{
    public class MyMathOperations
    {
        public double Add(double a, double b)
        {
            double value = a + b;

            return value;
        }

        public double Subtract(double a, double b)
        {
            double value = a - b;

            return value;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            double value = a / b;

            if (double.IsInfinity(value))
            {
                throw new DivideByZeroException();
            }

            return value;
        }

        public double Multiply(double a, double b)
        {
            double value = a*b;
            return value;

        }



    }
}
