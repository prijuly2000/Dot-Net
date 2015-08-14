using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPsConcept
{
    class SalesMgr : Emp
    {
        double commission;
        public SalesMgr()
        {
            commission = 0;
        }
        public SalesMgr(string nm, int d, int m, int y, int id, double bs, double cph)
            : base(nm, d, m, y, id, bs)
        {
            commission = cph;

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("commission=" + commission);

        }
        public new void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter commission");
            commission = double.Parse(Console.ReadLine());

        }

        public override double CalSal()
        {
            //return base.CalSal() + commission;
            return basic + commission;
        }
        public override string ToString()
        {
            string str = base.ToString();
            str += "\ncommission=" + commission;
            return str;
        }

        public override bool Equals(object obj)
        {
            SalesMgr s = (SalesMgr)obj;
            if (base.Equals(s) && this.commission == s.commission)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
