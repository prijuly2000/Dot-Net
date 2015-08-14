using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsDemo
{
    class Emp
    {
        int eid;
        string name;
        double basic;
        public Emp(string nm, int id, double bs)
        {
            name = nm;
            eid = id;
            basic = bs;
        }
        public override string ToString()
        {
            return "\nName=" + name + "\tEid=" + eid + "\tBasic=" + basic; ;
        }
    }
}
