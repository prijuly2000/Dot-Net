using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfIndia
{
    public class Saving:Account
    {
        int AvgBal;
        int interest;

        public Saving()
        {
            AvgBal = 0;
            interest = 0;
        }

        public Saving(int i, string nm, string d, int bal, int a, int inter)
            : base(i, nm, d, bal)
        {
            AvgBal = a;
            interest = inter;
        }

        public override string ToString()
        {
            string str = base.ToString();
            str += " Avg Balance:" + AvgBal + " interest:" + interest;
            return str;
        }

        public override double calbal()
        {
            double total = base.balance+ (base.balance * (interest / 100));
            return total;
        }
    }
}
