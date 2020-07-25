using System;
using System.Net;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress x = ComputerHost.GetAddress.GetHost("didesarrollc06j.tribunales.gov.ar");
            bool ping = PingHost.PingHost.Ping_Host(x);
            string mac = ComputerHost.GetAddress.getMacByIp(x.ToString());

            bool xd = WOL.Wake.WakeFunction("309c2350b6a2");
        }
    }
}
