using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

// Patryk Sala X00129065 

namespace CA2
{
    public abstract class Server : IComparable<Server>
    {
        private String serverName;
        private IPAddress ip;


        public Server(String serverName, IPAddress ip)
        {
            this.ServerName = serverName;
            this.Ip = ip;
        }

        // Read-Write property with private restricted set
        public String ServerName
        {
            get
            {
                return serverName;
            }

            private set
            {
                if (value.Length >= 1 && value.Length < 15)
                {

                    if (value.All(char.IsLetterOrDigit))
                    {
                        serverName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Server name can only contains letters and numbers");
                    }
                }
                else
                {
                    throw new ArgumentException("Server name needs to be between 1-15 characters");
                }
            }
        }

        // Read-Write property for the ip address
        public IPAddress Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public abstract String Restart();

        public int CompareTo(Server that)
        {
            if (that == null) return 1;

            return String.Compare(ip.GetHashCode().ToString(), that.Ip.GetHashCode().ToString());
        }
    }
}
