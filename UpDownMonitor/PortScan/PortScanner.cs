using System;
using System.Net.Sockets;

namespace UpDownMonitor.PortScan
{
    /// <summary>
    /// Class for scanning a specific port.
    /// </summary>
    public class PortScanner
    {
        /// <summary>
        /// Creates a new instance of this type.
        /// </summary>
        /// <param name="endPointName"></param>
        /// <param name="port"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public PortScanner(String endPointName, Int32 port)
        {
            if (string.IsNullOrWhiteSpace(endPointName))
            {
                throw new ArgumentException(nameof(endPointName));
            }

            if (port < 1 || port > 65535)
            {
                throw new ArgumentOutOfRangeException(nameof(port));
            }

            EndPointName = endPointName;
            Port = port;
        }

        /// <summary>
        /// Gets the port being scanned.
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// Gets the endpoint name (hostname, or IP address).
        /// </summary>
        public string EndPointName { get; private set; }

        /// <summary>
        /// Events for when the connection attempt is complete.
        /// </summary>
        public event EventHandler<PortScanResultEventArgs> PortScanResult;

        /// <summary>
        /// Begins the connection attempt via TCP.
        /// </summary>
        public void AttemptTcpConnectionToPort()
        {
            try
            {
                TcpClient client = new TcpClient {
                    ExclusiveAddressUse = false
                };
                client.Connect(EndPointName, Port);
                client.Close();

                PortScanResult?.Invoke(this, new PortScanResultEventArgs(EndPointName, Port, PortTypes.Tcp));
            }
            catch (SocketException)
            {
            }
        }

        /// <summary>
        /// Begins the connection attempt via UDP.
        /// </summary>
        public void AttemptUdpConnectionToPort()
        {

            try
            {
                UdpClient client = new UdpClient { ExclusiveAddressUse = false };
                client.Connect(EndPointName, Port);
                client.Close();

                if (PortScanResult != null)
                {
                    PortScanResult(this, new PortScanResultEventArgs(EndPointName, Port, PortTypes.Udp));
                }
            }
            catch (SocketException)
            {
            }
        }
    }
}