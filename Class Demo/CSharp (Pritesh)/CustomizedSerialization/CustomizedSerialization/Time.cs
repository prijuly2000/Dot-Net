using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


using System.Xml.Serialization;
using System.Runtime.Serialization;
namespace CustomizedSerialization
{
    [Serializable]
    public class Time :ISerializable
    {
       
        public int hr;
        public int min;
        public int sec;
       
        public Time()
        {
            hr = min = sec = 0;
        }

        public Time(SerializationInfo info, StreamingContext context)
        {
            hr=info.GetInt32("pritesh");
            min=info.GetInt32("neeraj");
            sec = info.GetInt32("swapnil");
        }

        public Time(int h, int m, int s)
        {
            hr = h;
            min = m;
            sec = s;
        }

        public override string ToString()
        {
            return "Time = " + hr + " : " + min + " : " + sec; 
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("pritesh", hr);
            info.AddValue("neeraj",min);
            info.AddValue("swapnil",sec);
        }
    }
}
