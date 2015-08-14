using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam
{
    class LinkList
    {
        Node start;

        public LinkList()
        {
            start = null;
        }

        public override string ToString()
        {
            string str="";
                Node p=start;
                while(p!=null)
                {
                    str+=" ";
                    str+=p.ToString();
                    p = p.NEXT;   
                }
                return str;
        }

        
        public int this[int index]
        {
            set
            {
                int i = value;
                Node temp = new Node(i);
                if (start == null)
                {
                    start = temp;
                    temp = null;
                    return;
                }
                if (start != null && index==0)
                {
                    temp.NEXT = start;
                    start = temp;
                    temp = null;
                    return;
                }
                else
                {
                    int j = 1;
                    Node p = start;
                    while (p.NEXT != null)
                    {
                        if (j == index)
                        {
                            Node q = p.NEXT;
                            p.NEXT = temp;
                            temp.NEXT = q;
                            temp = null;
                            return;
                        }
                        p = p.NEXT;
                    }
                    p.NEXT = temp;
                    temp.NEXT = null;
                    temp = null;
                }

            }


        }

        public override bool Equals(object obj)
        {
            LinkList l = (LinkList)obj;
            Node p = l.start;
            Node q=this.start;
            while (p != null && q != null)
            {
                if (p.DATA != q.DATA)
                {
                    return false;
                }

                p = p.NEXT;
                q = q.NEXT;
            }

            return true;
        }


       


    }
}
