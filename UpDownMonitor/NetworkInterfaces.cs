using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace UpDownMonitor
{
    internal static class NetworkInterfaces
    {
        public static IEnumerable<NetworkInterface> FetchAll() => NetworkInterface.GetAllNetworkInterfaces();

        public static IEnumerable<NetworkInterface> FetchOperational() => FetchAll().Where(nic => nic.OperationalStatus == OperationalStatus.Up);

        public static NetworkInterface Fetch(string id) => FetchAll().Where(nic => nic.Id == id).FirstOrDefault();
    }

}
