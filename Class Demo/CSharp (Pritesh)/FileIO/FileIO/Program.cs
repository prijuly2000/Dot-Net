using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main1(string[] args)
        {
            int x = 10;
            string str = "Hello";
            double d = 23.33;
            FileStream fs = new FileStream("File.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(x);
            sw.WriteLine(str);
            sw.WriteLine(d);
            sw.Close();
            fs.Close();
        }

        static void Main2()
        {
            FileStream fs = new FileStream("File.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while(!sr.EndOfStream)
                Console.WriteLine(sr.ReadLine());
            Console.ReadLine();
        }

        static void Main3()
        {
            FileStream fs = new FileStream("File.dat",FileMode.Create);
            BinaryWriter sw = new BinaryWriter(fs);
            sw.Write(12);
            sw.Write("Hi");
            sw.Write(1.1111);
            sw.Close();
        }

        static void Main4()
        {
            FileStream fs = new FileStream("File.dat",FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
            Console.ReadLine();
            br.Close();
        }

        static void Main5()
        {
            FileStream fs = new FileStream("FileByte.dat",FileMode.Create);
            byte b = 49;
            fs.WriteByte(b);
            fs.Close();
        }

        static void Main6()
        {
            FileStream fs = new FileStream("Multibyte.jpg", FileMode.Create);
            byte[] allbytes = File.ReadAllBytes("4.jpg");
            Console.WriteLine(allbytes.Length);
            fs.Write(allbytes,0,allbytes.Length);
            fs.Close();
        }

        static void Main()
        {
            DriveInfo[] dInfo = DriveInfo.GetDrives();
            foreach (DriveInfo d in dInfo)
            {
                Console.WriteLine(d.Name);
                DirectoryInfo dirInfo = d.RootDirectory;
                DirectoryInfo[] allDrives = dirInfo.GetDirectories();
                foreach (DirectoryInfo dir in allDrives)
                {
                    
                  
                    //Console.WriteLine(dir.Name);
                    try
                    {
                        FileInfo[] allFiles = dir.GetFiles();
                        
                        foreach (FileInfo f in allFiles)
                        {
                            //For displaying only text files
                            if(f.Extension==".txt")
                                Console.WriteLine(f.Name);                          
                            
                        }
                    }
                    catch (Exception ex)
                    {
                       // Console.WriteLine(ex.Message);
                        continue;
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
