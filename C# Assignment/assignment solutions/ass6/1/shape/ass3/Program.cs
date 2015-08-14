using System;

namespace ass3
{
    abstract class Shape
    {
        protected double area,peri;
        public abstract double CalArea();
        public abstract double CalPeri();
        public Shape()
        {
            area = 0;
            peri = 0;
        }
        public abstract void Accept();
        
        
    }
}
