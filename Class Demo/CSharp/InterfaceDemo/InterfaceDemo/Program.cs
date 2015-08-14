using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Provider p1 = new Provider();
            Consumer c1 = new Consumer();
            c1.DoCalculation(p1);
        }
    }
}
