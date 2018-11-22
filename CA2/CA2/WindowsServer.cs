using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

// Patryk Sala X00129065

namespace CA2
{
    public class WindowsServer : Server
    {
        // Constructor with a call to parent class constructor
        public WindowsServer(String name, IPAddress ip) : base(name, ip) { }

        public override string ToString()
        {
            return "Server name: " + ServerName + " IP: " + Ip;
        }

        public override String Restart()
        {
            return "Restarting Windows [" + ServerName + "] " + Ip + " with rundll32.exe shell32.dll, SHExitWindowsEx 2";
        }
    }
}
