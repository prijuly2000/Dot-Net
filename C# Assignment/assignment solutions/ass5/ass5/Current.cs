using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ass5
{
    class Current:Account
    {
        int CreditAmount;
	    double MonthlyCharges;

        public Current()
        {
            CreditAmount = 0;
            MonthlyCharges = 0;
        }

        public Current(int i, string n, int a, int b, int ca, int mc)
            : base(i, n, a, b)
        {
            CreditAmount = ca;
            if (CreditAmount <= 5000)
            {
                MonthlyCharges = 0.1;
            }
            else
            {
                MonthlyCharges = 0.2;
            }
        }

        public override void display()
        {
            Console.WriteLine("----Current-----");
            base.display();
            Console.WriteLine("Credit Amount:" + CreditAmount + "\nMonthly Charges:" + MonthlyCharges);
            Console.WriteLine("Total balance:" + calbal());
        }

        public override void accept()
        {
            base.accept();
            Console.WriteLine("Enter the credit amount");
            CreditAmount = int.Parse(Console.ReadLine());
            if (CreditAmount <= 5000)
            {
                MonthlyCharges = 0.1;
            }
            else
            {
                MonthlyCharges = 0.20;
            }

        }

        public override double calbal()
        {
            return (base.calbal() - base.calbal() * MonthlyCharges);
        }


    }
}
