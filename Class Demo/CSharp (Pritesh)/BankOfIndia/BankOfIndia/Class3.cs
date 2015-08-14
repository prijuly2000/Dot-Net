using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfIndia
{
    public class Current:Account
    {
        double credit;
        double monthly;

        public Current()
        {
            credit = monthly = 0;
        }

        public Current(int i, string nm, string d, int bal, int c, int m)
        {
            credit = c;
            monthly = m;
        }

        public override string ToString()
        {
            string str = base.ToString();
            str += " Credit Amount:" + credit + " Monthly Charges:" + monthly;
            return str;
        }

        public override double calbal()
        {
            double total = base.balance + base.balance * monthly;
            return total;
        }
    }
}
