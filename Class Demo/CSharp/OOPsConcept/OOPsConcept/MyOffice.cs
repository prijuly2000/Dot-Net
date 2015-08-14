using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPsConcept
{
    class MyOffice
    {
        Emp[] allEmp; //Ref of array
        public MyOffice(int size)
        {
            allEmp = new Emp[size]; //Array of ref
        }
        public Emp this[int index]
        {
            get
            {
                return allEmp[index];
            }
            set
            {
                allEmp[index] = value;
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach (Emp e in allEmp)
            {
                if (e != null)
                {
                    str += e.ToString();
                }
            }
            return str;
        }
    }
}
