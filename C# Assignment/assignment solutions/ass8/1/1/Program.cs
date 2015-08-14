using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class NumberConvertor
    {
        
        public NumberConvertor()
        {
           
        }

        public void Binary_To_Decimal()
        {
            Console.WriteLine("Enter thr binary number: ");
            string i = Console.ReadLine();
            Console.WriteLine("Decimal number:" + Convert.ToInt64(i, 2));
        }

        public void Decimal_To_Binary()
        {
            Console.WriteLine("Enter the Decimal number : ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary number: " + Convert.ToString(i, 2));

        }

        public void Binary_To_Octal()
        {
            Console.WriteLine("Enter the binary number: ");
            string i = Console.ReadLine();
            
            int integer = Convert.ToInt32(i, 2);
            Console.WriteLine("Octal number: "+Convert.ToString(integer, 8));
        }

        public void Octal_To_Binary()
        {
            Console.WriteLine("Enter the octal number: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Binary number: " + Convert.ToString(i, 2));

            

        }
    }
}
