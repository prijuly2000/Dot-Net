using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleInterfaces
{
    class Provider:Base,IA,IB
    {
        public void fB()
        {
            Console.WriteLine("fB from IB called") ;
        }

        public void fA()
        {
            Console.WriteLine("fA from IA called");
        }

        void IA.fCommon()
        {
            Console.WriteLine("fCommon from IA called");
        }

        void IB.fCommon()
        {
            Console.WriteLine("fCommon from IB called");
        }
    }
}
