using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDemo
{
    interface ICalculator
    {
        double Addition(double x, double y);
        double Substraction(double x, double y);
        double Multiplication(double x, double y);
        double Division(double x, double y);
    }
}
