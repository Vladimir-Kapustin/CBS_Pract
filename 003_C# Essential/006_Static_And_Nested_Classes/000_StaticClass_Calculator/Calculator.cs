using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_StaticClass_Calculator
{
    static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Devide(double x, double y)
        {
            return x / y;
        }
    }
}
