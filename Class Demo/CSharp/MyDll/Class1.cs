using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDll
{
    public class Emp
    {
        int eid;
        string name;
        double basic;
        public Emp(string nm,int i,double bs)
        {
            eid = i;
            name = nm;
            basic = bs;
        }
        public override string ToString()
        {
            return "\nName="+name+"\tEid="+eid+"\tBasic="+basic;
        }
    }
}
