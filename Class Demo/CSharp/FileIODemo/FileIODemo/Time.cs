using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FileIODemo
{
    [Serializable]
    public class Time
    {
        
        [XmlElement("Hour")]
        public int hr;
        [XmlElement("Min")]
        public int min;
        //[XmlIgnore] //To skip its serialization
        [XmlAttribute("Sec")]
        public int sec;
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
            return "Time="+hr+":"+min+":"+sec;
        }
    }
}
