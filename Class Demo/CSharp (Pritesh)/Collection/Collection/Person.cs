using System;

namespace Collection
{
    class Person
    {
        int id;
        string name;
        int salary;

        public Person()
        {
            id = 0;
            name = "";
            salary = 0;
        }

        public Person(int i,string nm, int y)
        {
            id = i;
            name = nm;
            salary = y;
        }

        public override string ToString()
        {
            string str = " Id:"+id+" Name:" + name+" Salary:"+salary;            
            return str;
        }
    }
}
