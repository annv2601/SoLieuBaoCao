using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace DuLieuBCCP
{
    public static class daKiemTraMang
    {
        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
                reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
                reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                //return false;
            }
            return pingable;
        }
    }
}
