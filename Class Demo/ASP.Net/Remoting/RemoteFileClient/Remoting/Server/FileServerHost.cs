using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace FirstApplication.Remoting.Server
{
    class FileServerHost
    {
        static void Main()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(FileServer), "MyFileServer", WellKnownObjectMode.SingleCall);
            TcpServerChannel channel = new TcpServerChannel(1244);
            ChannelServices.RegisterChannel(channel,true);
            Console.WriteLine("File server started. Press enter to terminate...");
            Console.ReadLine();
        }

    }
}
