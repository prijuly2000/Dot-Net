using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
namespace Serialization
{
    class MClass
    {
        //Binary Formatter :: Write operation
        public static void Main1()
        {
            FileStream fs = new FileStream("BinaryFormatter.dat", FileMode.Create);
            Time t1 = new Time(10, 20, 30);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, t1);
            fs.Close();
        }

        //Binary formatter :: Read Operation
        public static void Main2()
        {
            FileStream fs = new FileStream("BinaryFormatter.dat",FileMode.Open);
            Time t2;
            BinaryFormatter bf = new BinaryFormatter();
            t2=(Time)bf.Deserialize(fs);
            Console.WriteLine(t2);
            Console.ReadLine();
        }

        //Soap Formatter :: Write Operation

        public static void Main3()
        {
            FileStream fs = new FileStream("SoapFormatter.xml",FileMode.Create);
            Time t3 = new Time(10, 20, 30);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, t3);
            fs.Close();
        }

        //Soap Formatter :: Read Operation
        public static void Main4()
        {
            FileStream fs = new FileStream("SoapFormatter.xml", FileMode.Open);
            Time t4;
            SoapFormatter sf=new SoapFormatter();
            t4=(Time)sf.Deserialize(fs);
            Console.WriteLine(t4);
            Console.ReadLine();
        }

        //Xml Formatter :: Write Operation

        public static void Main()
        {
            FileStream fs = new FileStream("XmlFormatter.xml",FileMode.Create);
            Time t5 = new Time(50,100,150);
            XmlSerializer xf = new XmlSerializer(typeof(Time));
            xf.Serialize(fs,t5);
            fs.Close();
 
        }

        //Xml Formatter :: Read Operation
        public static void Main6()
        {
            FileStream fs = new FileStream("XmlFormatter.xml",FileMode.Open);
            Time t6;
            XmlSerializer xf = new XmlSerializer(typeof(Time));
            t6=(Time)xf.Deserialize(fs);
            Console.WriteLine(t6);
            Console.ReadLine();
        }
    }
}
