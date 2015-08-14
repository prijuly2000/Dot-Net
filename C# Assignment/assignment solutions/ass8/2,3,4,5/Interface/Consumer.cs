using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Consumer
    {
        public static void Main()
        {
            Calculator c = new Calculator();
            int choice;
            string ch="y";
            double num1, num2;
            while(ch=="y" || ch=="y")
            {
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Power");
                Console.WriteLine("6.Factorial");
                Console.WriteLine("Enter the choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the 1st & 2nd number:");
                        num1=double.Parse(Console.ReadLine());
                        num2=double.Parse(Console.ReadLine());
                        c.Addition(num1,num2);
                        break;
                    case 2:
                        Console.WriteLine("Enter the 1st & 2nd number:");
                        num1=double.Parse(Console.ReadLine());
                        num2=double.Parse(Console.ReadLine());
                        c.Sub(num1,num2);
                        break;
                    case 3:
                        Console.WriteLine("Enter the 1st & 2nd number:");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());
                        c.muli(num1, num2);
                        break;
                    case 4:
                        Console.WriteLine("Enter the 1st & 2nd number:");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());
                        c.div(num1, num2);
                        break;
                    case 5:
                        Console.WriteLine("Enter the 1st & 2nd number:");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());
                        c.power(num1, num2);
                        break;
                    case 6:
                        Console.WriteLine("Enter the number:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine(num1 + " Factorial : " + c.factorial(num1));
                        break;
                }

                Console.WriteLine("Wanna conti(y/n)");
                ch=Console.ReadLine();
            }

        }
    }
}
