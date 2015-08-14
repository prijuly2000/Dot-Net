using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfaces
{
    class provider:IA,IB
    {
        public void FA()
        {
            Console.WriteLine("FA from IA called");

        }
        public void FB()
        {
            Console.WriteLine("FB from Ib called");
        }

        public void FC()
        {
            Console.WriteLine("FC from IC called");
        }
        public void FAA()
        {
            Console.WriteLine("FAA from IA called");
        }
    }
}
