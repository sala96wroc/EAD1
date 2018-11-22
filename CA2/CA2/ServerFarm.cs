using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Patryk Sala X00129065

namespace CA2
{
    public class ServerFarm
    {

        List<Server> servers;

        public ServerFarm()
        {
            servers = new List<Server>();
        }

        public List<Server> Servers
        {
            get
            {
                return servers;
            }
        }

        // Adding server to the "rack" server farm
        public void AddServer(Server s)
        {
            if (servers.Any(sr => sr.Ip.GetHashCode() == s.Ip.GetHashCode()))
            { 
                    throw new ArgumentException("This IP address is already in the server rack");
            }
            
            servers.Add(s);
        }

        // only return once iterated over the whole collection
        public IEnumerable<String> RestartRack()
        {
           
            servers.Sort((x, y) => x.Ip.GetHashCode().CompareTo(y.Ip.GetHashCode()));
        
            foreach (Server s in servers)
            {
                yield return s.Restart();
            }
        }
    }
}
