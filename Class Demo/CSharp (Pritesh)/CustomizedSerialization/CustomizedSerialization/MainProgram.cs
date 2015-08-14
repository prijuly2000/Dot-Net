using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace CustomizedSerialization
{
    class MainProgram
    {
        //customized Serialization for SoapFormatter
        public static void Main1()
        {
            FileStream fs = new FileStream("XmlFormatter.xml", FileMode.Create);
            Time t5 = new Time(50, 100, 150);
            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, t5);
            fs.Close();

        }

        //customized Serialization for BinaryFormatter ::Write operation
        public static void Main2()
        {
            FileStream fs = new FileStream("BinaryFor.dat",FileMode.Create);
            Time t5 = new Time(10,20,30);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,t5);
            fs.Close();
        }
        //customized Serialization for BinaryFormatter ::Read operation
        public static void Main3()
        {
            FileStream fs = new FileStream("BinaryFor.dat",FileMode.Open);
            Time t5;
            BinaryFormatter bf = new BinaryFormatter();
            t5=bf.Deserialize(fs) as Time;
            Console.WriteLine(t5);
            Console.ReadLine();
        }

        //customized Serialization for SoapFormatter :: Read operation
        static void Main()
        {
            FileStream fs = new FileStream("XmlFormatter.xml", FileMode.Open);
            SoapFormatter sf = new SoapFormatter();
            Time t5=sf.Deserialize(fs) as Time;
            Console.WriteLine(t5);
            Console.ReadLine();
            fs.Close();
        }
    }
}
