using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_MVP_Calculator
{
    class Model
    {
        double result;
        public string Add(double a, double b)
        {
            result = a + b;
            return result.ToString();
        }

        public string Subtract(double a, double b)
        {
            result = a - b;
            return result.ToString();
        }
        public string Multiply(double a, double b)
        {
            result = a * b;
            return result.ToString();
        }
        public string Divide(double a, double b)
        {
            if (b!=0)
            {
                result = a / b;
                return result.ToString();
            }
            return "divide by zero";
            
        }
    }
}
