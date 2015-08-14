using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApplication.Remoting.Server
{
    public interface IFileServer
    {
        Byte[] getFile(String strFile);
        String getTime();
    }
}
