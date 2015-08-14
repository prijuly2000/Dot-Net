using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexer__poperty
{
    class Time
    {
        int hr, min, sec;
        public Time()
        {
            hr = min = sec = 0;
        }

        public Time(int h, int m, int s)
        {
            hr=h;
            min=m;
            sec=s;
        }

        public override string ToString()
        {
            string str = hr + " : " + min + " : " + sec;
            return str;
        }

        public int HR
        {
            get
            {
                return hr;
            }
            set
            {
                hr = value;
            }
        }

        public int MIN
        {
            get
            {
                return min;
            }

            set
            {
                min = value;
            }
        }

        public int SEC
        {
            get
            {
                return sec;
            }

            set
            {
                sec = value;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return hr;
                else if (index == 1)
                    return min;
                else
                    return sec;
            }

            set
            {
                if (index == 0)
                    hr = value;
                else if (index == 1)
                    min = value;
                else
                    sec = value;
            }

        }
    }
}
