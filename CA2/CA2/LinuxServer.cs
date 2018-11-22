using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

// Patryk Sala X00129065
namespace CA2
{
    // The only distros available - Enum
    public enum Distro { Debian, Ubuntu, RedHat, CentOS, Fedora};

    public class LinuxServer : Server
    {
        // Constructor with a call to parent constructor
        public LinuxServer(String serverName, IPAddress ip, Distro dist) : base(serverName, ip)
        {
            this.Dist = dist;
        }

        // Auto-implemented read-only property
        public Distro Dist { get; }

        public override string ToString()
        {
            return "Server name: " + ServerName + " IP: " + Ip.ToString() + " Distro: " + Dist.ToString();
        }

        public override String Restart()
        {
            return "Restarting Linux: [" + ServerName + "] " + Ip + " " + Dist + " with / sbin / shutdown -r now";
        }


    }
}
