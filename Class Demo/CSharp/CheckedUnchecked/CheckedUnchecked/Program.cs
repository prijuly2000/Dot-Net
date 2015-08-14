using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //By default the compiler does not
            //perform any arithmatic overflow or underflow check
            //We need to put this block inside checked block 
            //to tell the compiler to perform a check on overflow and
            //underflow, if so throw an exception
            unchecked
            {
                byte b = 255;
                Console.WriteLine(b);
                b++;
                Console.WriteLine(b);


            }
            
        }
    }
}
