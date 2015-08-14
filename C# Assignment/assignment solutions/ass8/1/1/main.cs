using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class main
    {
        public static void Main()
        {
            int choice;
            string ch = "y";
            NumberConvertor num = new NumberConvertor();
            while (ch == "Y" || ch == "y")
            {

                Console.WriteLine("----Conversion Operations----");
                Console.WriteLine("1.Binary To Decimal");
                Console.WriteLine("2.Decimal To Binary");
                Console.WriteLine("3.Binary To Octal");
                Console.WriteLine("4.Octal To Binary");
                Console.WriteLine("Enter the choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        num.Binary_To_Decimal();
                        break;
                    case 2:
                        num.Decimal_To_Binary();
                        break;
                    case 3:
                        num.Binary_To_Octal();
                        break;
                    case 4:
                        num.Octal_To_Binary();
                        break;


                }
                Console.WriteLine("Wanna conti(y/n)");
                ch = Console.ReadLine();
            }
        }
    }
}
