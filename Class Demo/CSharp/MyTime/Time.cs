using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTime
{
    class Time
    {
        int hr, min, sec;
        public Time()
        {
            hr = 0;
            min = 0;
            sec = 0;
        }
        public Time(int h,int m,int s)
        {
            hr = h;
            min = m;
            sec = s;
        }
        public override string ToString()
        {
            return hr+" : "+min+" : "+sec;
        }

        public int this[int index]
        {
          
            get
            {
                try
                {
                    if (index == 0)
                    {
                        return hr;
                    }
                    else if (index == 1)
                    {
                        return min;
                    }
                    else if (index == 2)
                    {
                        return sec;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            set 
            {
                if (index == 0)
                {
                    hr=value;
                }
                else if (index == 1)
                {
                    min=value;
                }
                else
                {
                    sec=value;
                }
            }
        

        }

        public int this[string index]
        {
            get
            {
                if (index == "hr")
                {
                    return hr;
                }
                else if (index == "min")
                {
                    return min;
                }
                else
                {
                    return sec;
                }
            }
            set
            {
                if (index == "hr")
                {
                   hr=value;
                }
                else if (index == "min")
                {
                    min=value;
                }
                else
                {
                    sec=value;
                }
            }
        }


        //t2 => obj (Upcasting)
        public override bool Equals(object obj)
        {
            Time t = (Time)obj; //Downcasting
            if (this.hr == t.hr && 
                this.min == t.min && 
                this.sec == t.sec)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static Time operator +(Time t1, Time t2)
        {
            Time t = new Time();
            t.hr = t1.hr+t2.hr;
            t.min = t1.min + t2.min;
            t.sec = t1.sec + t2.sec;
            return t;

        }


        //Relational operators are overloaded in pairs
        public static bool operator >(Time t1, Time t2)
        {
            if (t1.hr > t2.hr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Time t1, Time t2)
        {
            if (t1.hr < t2.hr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //t1=x
        public static implicit operator Time(int x)
        {
            Time t = new Time(x, x, x);
            return t;
        }
        //x=(int)t
        public static explicit operator int(Time t)
        {
            return t.hr+t.min+t.sec;
        }
    }
}
