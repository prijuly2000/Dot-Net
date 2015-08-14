using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfIndia
{
    class Bank
    {
        Account[] a;
        public Bank()
        {
            a = new Account[10];
        }

        public Bank(int size)
        {
            a = new Account[size];
        }

        public override string ToString()
        {
            string str = "";
            foreach (Account a1 in a)
            {
                str += a.ToString();
            }
            return str;
        }

        public Account this[int index]
        {
            get { return a[index]; }
            set{a[index]=value;}
        }


    }
}
