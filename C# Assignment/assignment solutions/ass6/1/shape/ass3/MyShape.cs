using System;

namespace ass3
{
    class MyShape
    {
        Shape[] m;
        public MyShape(int size)
        {
            m = new Shape[size];
        }
        public Shape this[int index]
        {
            get
            {
                return m[index];
            }
            set
            {
                m[index] = value;
            }
        }
        //public static 

    }
}
