using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Calculator : IBasicCalculator, IScientificCalculator
    {

        public void Addition(double x, double y)
        {
            Console.WriteLine("Addition : " +( x + y));
        }

        public void Sub(double x, double y)
        {
            Console.WriteLine("Subtraction : " + (x - y)); ;
        }


        public void muli(double x, double y)
        {
            Console.WriteLine("Multiplication : " + ( x * y));
        }

        public void div(double x, double y)
        {
            Console.WriteLine("Division :"+(x / y));
        }

        public void power(double x, double y)
        {
            Console.WriteLine("Power : " + Math.Pow(x, y));
        }

        public double factorial(double x)
        {
            double result=1;
            while(x>1)
            {
                result=result*x;
                x--;
            }

            return result;
        }

         void IBasicCalculator.display()
        {          
                       
        }

         void IScientificCalculator.display()
        {
            double num1, num2;
            Console.WriteLine("Enter the 1st & 2nd number:");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            power(num1, num2);
            
            Console.WriteLine(num2 + " Factorial : " + factorial(num2));

        }
    }
}
