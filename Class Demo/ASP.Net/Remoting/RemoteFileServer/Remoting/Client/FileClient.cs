using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApplication.Remoting.Client
{
    class FileClient
    {
        static void Main1()
        {
            IFileServer iFileServer = (IFileServer) Activator.GetObject(typeof(IFileServer), "tcp://localhost:1244/MyFileServer");
            Byte[] arrData= iFileServer.getFile("Test.txt");
            Console.WriteLine("Received " + arrData.Length + "bytes from server");

        }

    }
}
