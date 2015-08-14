using System;


namespace _2
{
    class Myoffice
    {
        Emp[] allEmp;

        public Myoffice(int size)
        {
            allEmp = new Emp[size];

        }

        public Emp this[int index]
        {
            
            set
            {
                
                allEmp[index] = value;
            }
            get
            {
                Console.WriteLine("indexer");
                return allEmp[index];
            }
        }
        public override string  ToString()
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
