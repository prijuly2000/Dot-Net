using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDemo
{
    class Consumer
    {
        public void DoCalculation(ICalculator ic)
        {
            Console.WriteLine(ic.Addition(10, 20));
            Console.WriteLine(ic.Substraction(10, 20));

            //Downcasting
            Console.WriteLine(((Provider)ic).Mod(10, 2));
        }
    }
}
