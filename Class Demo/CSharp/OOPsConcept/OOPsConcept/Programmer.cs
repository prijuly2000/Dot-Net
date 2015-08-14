using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPsConcept
{
    class Programmer:Emp
    {
        double costPerHrs;
        int extraHrs;
        public Programmer()
        {
            costPerHrs = 0;
            extraHrs = 0;
        }
        public Programmer(string nm, int d, int m, int y, int id, double bs, int eh, double cph)
            : base(nm, d, m, y, id, bs)
        {
            costPerHrs = cph;
            extraHrs = eh;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Cost Per Hrs=" + costPerHrs);
            Console.WriteLine("Extra Hrs=" + extraHrs);
        }
        public new void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter cost per hrs");
            costPerHrs = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter extra hrs");
            extraHrs = int.Parse(Console.ReadLine());
        }
        public override double CalSal()
        {
            //return base.CalSal()+extraHrs*costPerHrs;
            return basic + extraHrs * costPerHrs;
        }

        public override string ToString()
        {
            string str = base.ToString();
            str+="\nCost Per Hrs=" + costPerHrs;
            str+="\tExtra Hrs=" + extraHrs;
            return str;
        }

        public override double Salary
        {
            get
            {
                return basic + costPerHrs*extraHrs;
            }
        }

        public override bool Equals(object obj)
        {
            Programmer p = (Programmer)obj;
            if (base.Equals(p) && this.extraHrs == p.extraHrs && this.costPerHrs == p.costPerHrs)
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
