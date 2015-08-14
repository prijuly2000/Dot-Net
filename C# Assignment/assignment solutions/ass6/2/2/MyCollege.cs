using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class MyCollege
    {
        Student start;
               
        public MyCollege()
        {
            start = null;            
        }

        
        public override string ToString()
        {
            string str = "";
            Student p = start;
            while(p!=null)
            {
                str += "\n---------------\n";
                str+=p.ToString();
                str += "\n---------------\n";
                p = p.NEXT;
            }
            return str;
        }

        public Student this[int index]
        {
            set
            {
                Student temp = value;
                if(index==0 || start==null)
                {
                    temp.NEXT = start;
                    start = temp;
                    temp = null;
                    return;
                }
                int i=1;
                Student p = start;
                while (p.NEXT != null)
                {
                    if (i == index-1 )
                    {
                        temp.NEXT = p.NEXT;
                        p.NEXT = temp;
                        temp = null;
                        return;
                    }

                    i++;
                    p = p.NEXT;
                }
                p.NEXT = temp;
                temp = null;
                        
            }

            get
            {
                if (start == null)
                {
                    return null;
                }

                if (index == 0)
                {
                    Student p = start;
                    start = start.NEXT;
                    return p;
                }
                int i=1;
                Student p1 = start;
                while (p1 != null)
                {
                    if (i == index-1)
                    {
                        Student q = p1.NEXT;
                        p1.NEXT = q.NEXT;
                        return q;
                    }
                    i++;
                    p1=p1.NEXT;
                }
                return null;
            }
        }

    }
}
