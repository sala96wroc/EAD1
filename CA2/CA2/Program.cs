using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

// Patryk Sala X00129065

namespace CA2
{
    class Program
    {
        public static void Main()
        {
            // Create test servers
            LinuxServer ls = new LinuxServer("linux", IPAddress.Parse("152.168.1.0"), Distro.CentOS);
            WindowsServer ws = new WindowsServer("Win", IPAddress.Parse("192.168.1.0"));
            WindowsServer ws1 = new WindowsServer("test", IPAddress.Parse("222.168.10.0"));

            // Create server farm
            ServerFarm sf = new ServerFarm();

            sf.AddServer(ws);
            sf.AddServer(ws1);
            sf.AddServer(ls);

            // Iterate over IEnumerable return from ServerFarm class
            foreach (String s in sf.RestartRack())
            {
                Console.WriteLine(s);
            }
        }
    }
}
