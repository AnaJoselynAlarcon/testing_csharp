using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathTesting
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

        public double Multiply(double a, double b)
        {
            double value = a * b;
            return value;
        }

        public double Divide(double a, double b)
        {
            double value = a / b;
            return value;
        }
    }
}
