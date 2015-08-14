using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Remoting;

namespace FirstApplication.Remoting.Server
{
    public class FileServer : MarshalByRefObject, IFileServer
    {
        public String getTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        public Byte[] getFile(String strFile)
        {
            strFile = "D:/Test/"+strFile;
            if (File.Exists(strFile))
            {
                return File.ReadAllBytes(strFile);
            }
            else
            {
                return null;
            }
        }
    }
}
