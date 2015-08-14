using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Remoting;

namespace FirstApplication.Remoting.Server
{
    class FileServer : MarshalByRefObject, IFileServer
    {
        public Byte[] getFile(String strFile)
        {
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
