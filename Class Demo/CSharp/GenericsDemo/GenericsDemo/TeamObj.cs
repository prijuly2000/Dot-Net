using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsDemo
{
    class TeamObj
    {
        object[] allMembers;
        public TeamObj(int size)
        {
            allMembers = new object[size];
        }
        public object this[int index]
        {
            get
            {
                return allMembers[index];
            }
            set
            {
                allMembers[index] = value;
            }
        }
        public override string ToString()
        {
            string str = "";
            foreach (object obj in allMembers)
            {
                if (obj != null)
                {
                    str += obj.ToString();
                }
            }
            return str;
        }
    }
}
