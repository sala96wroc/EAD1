using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA2;
using System.Net;

namespace CA2Tests
{
    [TestClass]
    public class UnitTest1
    {
        // This test checks if the AddServer() adds a server correctly
        [TestMethod]
        public void AddServerTest()
        {
            IPAddress ip = IPAddress.Parse("192.168.1.0");
            WindowsServer ws = new WindowsServer("Win", ip);

            ServerFarm sf = new ServerFarm();
            sf.AddServer(ws);

            CollectionAssert.Contains(sf.Servers, ws);
        }

        // This test checks if the server farm doesn't let two servers with the same ip addresses
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddTheSameServer()
        {
            IPAddress ip = IPAddress.Parse("192.168.1.0");
            IPAddress ip1 = IPAddress.Parse("192.168.1.0");

            WindowsServer ws = new WindowsServer("Win", ip);
            WindowsServer ws1 = new WindowsServer("Win", ip1);

            ServerFarm sf = new ServerFarm();
            sf.AddServer(ws);
            sf.AddServer(ws1);
        }
    }
}
