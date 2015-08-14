#define FOURTH  //Turn it ON
#undef FOURTH   //turn it OFF
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PreprocessorDirectives
{
    class Program
    {
        static void Main1(string[] args)
        {

#if FIRST
            Console.WriteLine("First Section");
#elif SECOND
            Console.WriteLine("Second Section");
#elif THIRD
            Console.WriteLine("Third Section");
#elif FOURTH
            Console.WriteLine("Fourth Section");
#else
            Console.WriteLine("Fifth Section");
#error "Don't forget the fourth section, it is very imp"
#endif
        }

        //Collapsable region
        static void Main(string[] args)
        {

            #region 


            //factorial code
            int x = 4,f=1;
            while (x >= 1)
            {
                f = f * x--;
            }
            Console.WriteLine("Factorial=" + f);

            #endregion


            #region POWER


            //m ^ n
            int m = 4, n = 3,p=1;
            while (n >= 1)
            {
                p = p * m;
                n--;
            }
            Console.WriteLine("Result=" + p);

            #endregion

        }
    }
}
