using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam
{
    class Node
    {
        int data;
        Node next;

        public Node()
        {
            data = 0;
            next = null;
        }

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public int DATA
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }

        }

        public Node NEXT
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public override string ToString()
        {
            string str = data.ToString();
            return str;
        }
    }
}
