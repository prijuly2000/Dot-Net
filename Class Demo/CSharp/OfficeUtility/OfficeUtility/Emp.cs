using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeUtility
{
    public abstract class Emp:Person
    {
        int eid;
        protected double basic;
        //Read only property
        public virtual double Salary
        {
            get
            {
                return basic;
            }
        }

        //public abstract double Salary
        //{
        //    get;
        //    set;
        //}

        public Emp()
        {
            eid = 0;
            basic = 0;
        }
        public Emp(string nm, int d, int m, int y, int id, double bs)
            :base(nm,d,m,y) //Member Initialization List
        {
            eid = id;
            basic = bs;
        }
        public virtual void Display()
        {
            base.Display();
            Console.WriteLine("Eid=" + eid);
            Console.WriteLine("Basic=" + basic);
        }
        public new void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter eid");
            eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Basic");
            basic = double.Parse(Console.ReadLine());
        }
        //Pure virtual method
        public abstract double CalSal();
        //{
        //    return basic;
        //}


        public override string ToString()
        {
            string str = base.ToString();
            str += "\tEid=" + eid;
            str += "\tBasic=" + basic;
            return str;
        }

        //e1.Equals(e2)
        //e1 => this
        //e2 => obj => e
        public override bool Equals(object obj)
        {
            Emp e = (Emp)obj;
            //Person's Equals method
            if (base.Equals(e) && 
                this.basic == e.basic &&
                this.eid == e.eid)
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
