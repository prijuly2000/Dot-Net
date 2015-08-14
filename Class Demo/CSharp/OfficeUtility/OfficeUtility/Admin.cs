using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeUtility
{
    public class Admin : Emp
    {
        double incentive;      
        public Admin()
        {
            incentive = 0;           
        }
        public Admin(string nm, int d, int m, int y, int id, double bs,  double cph)
            : base(nm, d, m, y, id, bs)
        {
            incentive = cph;
          
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Incentive=" + incentive);
            
        }
        public new void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter incentive");
            incentive = double.Parse(Console.ReadLine());
            
        }

        public override double CalSal()
        {
            //return base.CalSal() + incentive;
            return basic + incentive;
        }

        public override string ToString()
        {
            string str = base.ToString();
            str += "\nIncentive=" + incentive;           
            return str;
        }

        public override bool Equals(object obj)
        {
            Admin a = (Admin)obj;
            if (base.Equals(a) && this.incentive == a.incentive)
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
