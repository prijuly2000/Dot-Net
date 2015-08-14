using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using FirstApplication.Remoting.Server;

namespace FirstApplication.Remoting.Client
{
    class FileClient
    {
        static void Main()
        {
            IFileServer iFileServer = (IFileServer) Activator.GetObject(typeof(IFileServer), 
                "tcp://127.0.0.1:6010/MyFileServer");

            Console.WriteLine( iFileServer.getTime());

            Byte[] arrData= iFileServer.getFile("Del.txt");
            Console.WriteLine("Received " + arrData.Length + "bytes from server");
       //     FileStream fs = File.Create("D:/Object/delete/temp2/Winter.jpg");
        //    fs.Write(arrData, 0, arrData.Length);
        //    fs.Close();
        }

    }
}
