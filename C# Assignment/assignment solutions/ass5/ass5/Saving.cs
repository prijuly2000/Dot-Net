using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ass5
{
    class Saving:Account
    {
        int AverageBalance;
        double Interest;

        public Saving()
        {
            AverageBalance = 0;
            Interest = 0;
        }

        public Saving(int i, string n, int a, int b, int ab, int intr)
            : base(i, n, a, b)
        {
            AverageBalance = ab;
            Interest = intr;
        }

        public override void display()
        {
            Console.WriteLine("-----Saving Account-----");
            base.display();
            Console.WriteLine("Average Balance:"+AverageBalance+"\nInterest:"+Interest);
            Console.WriteLine("Total balance:"+calbal());
        }

        public override void accept()
        {
            base.accept();
            Console.WriteLine("Enter the average balance");
            AverageBalance = int.Parse(Console.ReadLine());
            if (AverageBalance <= 5000)
            {
                Interest = 0.1;
            }
            else
            {
                Interest = 0.20;
            }

        }

        public override double calbal()
        {
            return (base.calbal()+base.calbal()*Interest);
        }

    }
}
