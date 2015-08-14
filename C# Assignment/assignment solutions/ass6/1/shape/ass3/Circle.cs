using System;


namespace ass3
{
    class Circle:Shape
    {
        double radius;
        public Circle()
        {
            radius = 0;
        }
        public Circle(double ra)
        {
            radius = ra;
            base.area = CalArea();
            base.peri = CalPeri();
        }
        public override void  Accept()
        {
            Console.Write("Enter Radius : ");
           radius = double.Parse(Console.ReadLine());
           base.area = CalArea();
           base.peri = CalPeri();
        }
        public override double CalArea()
        {
            return (radius * radius * 3.14);
        }
        public override double CalPeri()
        {
            return (2 * 3.14 * radius);
        }
        public override string ToString()
        {
            string str = "area: " + base.area;
            str += "\nperi: " + base.peri;
            str += "\n"+"radius: " + radius;
            return str;
        }
    }
}
