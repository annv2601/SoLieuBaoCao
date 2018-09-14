using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;

namespace daoSLPH.Untities
{
    public class daThongTinMay:clsMayClient
    {
        public daThongTinMay()
        {
            TenMay = "";
            DiaChiIP = "";
            MAC = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        MAC = nic.GetPhysicalAddress().ToString();
                        UnicastIPAddressInformationCollection n = nic.GetIPProperties().UnicastAddresses;
                        DiaChiIP = n[0].Address.ToString();
                    }
                }
            }
            TenMay = Dns.GetHostName();
        }
    }

    public class clsMayClient
    {
        private string _TenMay;

        private string _DiaChiIP;

        private string _MAC;

        public string TenMay { get => _TenMay; set => _TenMay = value; }
        public string DiaChiIP { get => _DiaChiIP; set => _DiaChiIP = value; }
        public string MAC { get => _MAC; set => _MAC = value; }
    }
}
