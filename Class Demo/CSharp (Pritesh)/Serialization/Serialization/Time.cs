using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


using System.Xml.Serialization;
namespace Serialization
{
    [Serializable]
    public class Time
    {
       //  [NonSerialized] //to ignore "hr" from writing to the file
        [XmlElement("Hour")]
        public int hr;
      //  [XmlIgnore] //to ignore "min" from writing to the file in the Xml Serialization only
        [XmlElement("Minute")]  //Change the XML tags for the data members
        public int min;
        [XmlAttribute("Second")]  //Make the data member as the attribute in XML file while writing
        public int sec;
       
        public Time()
        {
            hr = min = sec = 0;
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
        
    }
}
