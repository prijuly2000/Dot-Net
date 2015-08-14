using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class Team
    {
        object[] allMember;

        public Team(int size)
        {
            allMember = new object[size];
        }

        public object this[int index]
        {
            get
            {
                return allMember[index];
            }
            set
            {
                allMember[index] = value;
            }
        }

        
    }
}
