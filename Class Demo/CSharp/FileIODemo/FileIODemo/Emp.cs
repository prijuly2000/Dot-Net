using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileIODemo
{
    [Serializable]
    class Emp
    {
        int id;
        string name;
        //Applicable for binary as well as soap
        [NonSerialized] //To skip the serialization  
        double basic;
        public Emp()
        {
            this.id = 0;
            name = "";
            basic = 0;
        }
        public Emp(string nm, int id, double bs)
        {
            this.id = id;
            name = nm;
            basic = bs;
        }
        public override string ToString()
        {
            return "\nName=" + name + "\tId=" + id + "\tBasic=" + basic;
        }
    }
}
