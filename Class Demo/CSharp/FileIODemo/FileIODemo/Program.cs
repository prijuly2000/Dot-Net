using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//For File IO
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//Explicitly add the reference => search in .net tab
using System.Runtime.Serialization.Formatters.Soap;

using System.Xml.Serialization;

namespace FileIODemo
{
    class Program
    {
        //Text Write
        static void Main1(string[] args)
        {
            int x = 10;
            string str = "Hello";
            double d = 23.33;

            FileStream fs = new FileStream
                (@"D:\myfile.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(x);
            sw.WriteLine(str);
            sw.WriteLine(d);
            sw.Close();
            fs.Close();
           
        }
        //Text Read
        static void Main2(string[] args)
        {
            FileStream fs = new FileStream("myfile.txt",
                FileMode.Open); //To read
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
        //Binary Write
        static void Main3(string[] args)
        {
            FileStream fs = new FileStream
                ("myFile.dat", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int x = 10;
            double d = 23.33;
            string str = "Hello";
            bw.Write(x);
            bw.Write(d);
            bw.Write(str);
            bw.Close();
            fs.Close();
        }
        //Binary Read
        static void Main4(string[] args)
        {
            FileStream fs = new FileStream
                ("myFile.dat", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            //Sequence of read must be same as the 
            //sequence of write            
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadString());
            br.Close();
            fs.Close();
        }
        static void Main5(string[] args)
        {
            FileStream fs = 
                new FileStream("batchB", FileMode.Create);
            byte b = 123;
            //Write a single byte
            fs.WriteByte(b);
            fs.Close();
        }
        static void Main6(string[] args)
        {
            FileStream fs =
                new FileStream("myImage.jpg", FileMode.Create);
             byte []allBytes =
                 File.ReadAllBytes(@"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Sunset.jpg");
             Console.WriteLine(allBytes.Length);
             fs.Write(allBytes, 0, allBytes.Length);            
             fs.Close();
        }
        static void Main7(string[] args)
        {
            DriveInfo []dInfo = 
                DriveInfo.GetDrives();
            foreach (DriveInfo d in dInfo)
            {
                //Console.WriteLine(d.Name);
                //Get the root directory of that drive
                //Console.WriteLine(d.RootDirectory); 

                DirectoryInfo dirInfo = 
                    d.RootDirectory;

               // Directory.

                DirectoryInfo []allDrives=
                    dirInfo.GetDirectories();
                foreach (DirectoryInfo dir in allDrives)
                {
                    Console.WriteLine(dir.Name);
                    FileInfo[] allFiles = dir.GetFiles();
                    //dir.GetDirectories();
                }

            }

            
        }
        static void Main8(string[] args)
        {
            FileStream fs = new FileStream
                ("myPlayer", FileMode.Create);
            //Emp e1 = new Emp("AAAA", 101, 10000);
            Player p1 = new Player("sachin", 101, 120);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, p1);
            fs.Close();
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream
                ("myPlayer", FileMode.Open);
            Player e1; 
            BinaryFormatter bf = new BinaryFormatter();
            e1 = (Player)bf.Deserialize(fs);
            Console.WriteLine(e1);
            fs.Close();
        }

        static void Main13(string[] args)
        {
            FileStream fs = new FileStream
                ("myEmp.xml", FileMode.Create);
            Emp e1 = new Emp("AAAA", 101, 10000);
            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, e1);
            fs.Close();
        }
        static void Main10(string[] args)
        {
            FileStream fs = new FileStream
                ("myEmp.xml", FileMode.Open);
            Emp e1;
            SoapFormatter bf = new SoapFormatter();
            e1 = (Emp)bf.Deserialize(fs);
            Console.WriteLine(e1);
            fs.Close();
        }

        static void Main11(string[] args)
        {
            XmlSerializer xr = 
                new XmlSerializer(typeof(Player));
            Player p1 = new Player("Sachin", 101, 120);
            FileStream fs = new FileStream
                ("myTime.xml", FileMode.Create);
            xr.Serialize(fs, p1);
            fs.Close();
        }
        static void Main12(string[] args)
        {
            XmlSerializer xr =
                new XmlSerializer(typeof(Time));
            Time t1 ;
            FileStream fs = new FileStream
                ("myTime.xml", FileMode.Open);
            t1=(Time)xr.Deserialize(fs);
            Console.WriteLine(t1);
            fs.Close();
        }
    }
}

