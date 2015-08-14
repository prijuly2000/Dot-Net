using System;


namespace ass3
{
    class Triangle:Shape
    {
        double height, base1;
        public Triangle()
        {
            height = 0;
            base1 = 0;
        }
        public Triangle(double h, double b)
        {
            height = h;
            base1 = b;
            base.area = CalArea();
            base.peri = CalPeri();
        }
        public override void Accept()
        {
            Console.Write("Enter Height : ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter Base1 : " );
            base1 = double.Parse(Console.ReadLine());
            base.area = CalArea();
            base.peri=CalPeri();
        }
        public override double CalArea()
        {
            return (0.5*height * base1);
        }
        public override double CalPeri()
        {
            double h = Math.Sqrt(Math.Pow(base1, 2)+ Math.Pow(height, 2));
            return (h+base1+height);
        }

        public override string ToString()
        {
            string str = "area: " + base.area;
            str += "\nperi: " + base.peri;
            str += "\nheight: " + height + "\nbase: " + base1;
            return str;
        }
    }
}
