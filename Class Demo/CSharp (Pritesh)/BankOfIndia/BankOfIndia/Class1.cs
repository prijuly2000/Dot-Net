using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOfIndia
{
    abstract public class Account
    {
        public int id;
        string name;
        string dob;
        protected int balance;
        public Account()
        {
            id = balance = 0;
            name = dob = "";
        }

        
        public Account(int i,string nm,string d,int b)
        {
            id = i;
            balance = b;
            name = nm;
            dob = d;
        }

        public override string ToString()
        {
            string str = "";
            str += " id:" + id + " Name:" + name + " DOB:" + dob + " Balance:" + balance;
            return str;
        }

        public abstract double calbal();


    }
}
