using System;


namespace ass3
{
    class Rectangle:Shape
    {
        double length, breadth;
        public Rectangle()
        {
            length = 0;
            breadth = 0;
        }
        public Rectangle(double len,double bre)
        {
            length = len;
            breadth = bre;
            base.area = CalArea();
            base.peri = CalPeri();
        }
        public override void Accept()
        {
            Console.Write("Enter Length : ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter Breadth : ");
            breadth = double.Parse(Console.ReadLine());
            base.area = CalArea();
            base.peri = CalPeri();
        }
        public override double CalArea()
        {
            return (length * breadth);
        }
        public override double CalPeri()
        {
            return (2*(length+breadth));
        }
        public override string ToString()
        {
            string str = "area: " + base.area;
            str += "\nperi: " + base.peri;
            str += "\nlength: " + length + "\nbreadth: " + breadth;
            return str;
        }
        
    }
}
