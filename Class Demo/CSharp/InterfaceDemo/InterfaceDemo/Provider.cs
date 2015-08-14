using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDemo
{
    class Provider:ICalculator
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Substraction(double x, double y)
        {
            return x-y;
        }

        public double Multiplication(double x, double y)
        {
            return x*y;
        }

        public double Division(double x, double y)
        {
            return x/y;
        }

        public double Mod(double x, double y)
        {
            return x % y;
        }


    }
}
