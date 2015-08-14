using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Provider p = new Provider();
            p.fA();
            p.fB();
            p.fBase();
            p.fCommon();
            ((IA)p).fCommon();
            ((IB)p).fCommon();
        }
    }
}
