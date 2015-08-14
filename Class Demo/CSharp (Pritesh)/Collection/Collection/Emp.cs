using System;


namespace Collection
{
    class Emp
    {
        int id;
        string name;
        double basic;
        public Emp()
        {
            id = 0;
            name = "";
            basic = 0;
        }

        public Emp(int i,string nm,double b)
        {
            id = i;
            name = nm;   
            basic = b;
        }
        public override string ToString()
        {
            string str = " Id:" + id;
            str += " Name:" + name;
            str += " Salary:" + basic;
            return str;
        }

    }
}
