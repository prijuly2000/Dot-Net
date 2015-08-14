using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandlingDemo
{
    //User defined exception
    class MyException:ApplicationException
    {
        //virtual property => Message

        public override string Message
        {
            get
            {
                return "Number is not in the desired range....";
            }
        }
    }
}
