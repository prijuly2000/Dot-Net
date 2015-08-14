using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsDemo
{
    class Team<T>
    {
        T[] allMembers;
        public Team(int size)
        {
            allMembers = new T[size];
        }
        public T this[int index]
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
            foreach (T obj in allMembers)
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
