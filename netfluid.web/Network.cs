// ********************************************************************************************************
// <copyright company="NetFluid">
//     Copyright (c) 2013 Matteo Fabbri. All rights reserved.
// </copyright>
// ********************************************************************************************************
// The contents of this file are subject to the GNU AGPL v3.0 (the "License"); 
// you may not use this file except in compliance with the License. You may obtain a copy of the License at 
// http://www.fsf.org/licensing/licenses/agpl-3.0.html 
// 
// Commercial licenses are also available from http://netfluid.org/, including free evaluation licenses.
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
// ANY KIND, either express or implied. See the License for the specific language governing rights and 
// limitations under the License. 
// 
// The Initial Developer of this file is Matteo Fabbri.
// 
// Contributor(s): (Open source contributors should list themselves and their modifications here). 
// Change Log: 
// Date           Changed By      Notes
// 23/10/2013    Matteo Fabbri      Inital coding
// ********************************************************************************************************

using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Netfluid
{
    /// <summary>
    ///     Return important data about the connected network
    /// </summary>
    public class Network
    {
        /// <summary>
        /// Broadcast a message on the local network
        /// </summary>
        /// <param name="message">message to send</param>
        /// <param name="port">recievers port</param>
        public static void Broadcast(byte[] message, int port)
        {
            var udp = new UdpClient();
            var endpoint = new IPEndPoint(IPAddress.Broadcast, port);
            udp.Send(message, message.Length, endpoint);
            udp.Close();
        }

        /// <summary>
        ///     All available physical network interfaces
        /// </summary>
        public static NetworkInterface[] Interfaces
        {
            get { return NetworkInterface.GetAllNetworkInterfaces(); }
        }

        /// <summary>
        ///     True if the machine is connected to the network
        /// </summary>
        public static bool Connected
        {
            get { return NetworkInterface.GetIsNetworkAvailable(); }
        }

        /// <summary>
        ///     Return the loopback physical inetrface
        /// </summary>
        public static NetworkInterface Loopback
        {
            get { return Interfaces[NetworkInterface.LoopbackInterfaceIndex]; }
        }

        /// <summary>
        ///     Return all ip address of the current machine
        /// </summary>
        public static IPAddress[] Addresses
        {
            get
            {
                return System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
            }
        }

        /// <summary>
        ///     Return all ip address of the current machine plus 127.0.0.1
        /// </summary>
        public static IPAddress[] AddressesWithLocalhost
        {
            get
            {
                return System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.Concat(IPAddress.Parse("127.0.0.1")).ToArray();
            }
        }

        /// <summary>
        ///   Return all ip V4 address of the current machine
        /// </summary>
        public static IPAddress[] AddressesIPV4
        {
            get
            {
                return AddressesWithLocalhost.Where(x => x.GetAddressBytes().Length == 4).ToArray();
            }
        }

        /// <summary>
        ///   Return all ip V6 address of the current machine
        /// </summary>
        public static IPAddress[] AddressesIPV6
        {
            get
            {
                return AddressesWithLocalhost.Where(x => x.GetAddressBytes().Length == 16).ToArray();
            }
        }

        /// <summary>
        ///     Gets a list of default DNS servers used by system
        /// </summary>
        /// <returns></returns>
        public static IPAddress[] Dns
        {
            get
            {
                var adapters =
                    NetworkInterface.GetAllNetworkInterfaces().Where(x => x.OperationalStatus == OperationalStatus.Up);
                return adapters.SelectMany(x => x.GetIPProperties().DnsAddresses).ToArray();
            }
        }

        /// <summary>
        ///     Gets a list of default DHCP servers used by system
        /// </summary>
        /// <returns></returns>
        public static IPAddress[] Dhcp
        {
            get
            {
                var adapters =
                    NetworkInterface.GetAllNetworkInterfaces().Where(x => x.OperationalStatus == OperationalStatus.Up);
                return adapters.SelectMany(x => x.GetIPProperties().DhcpServerAddresses).ToArray();
            }
        }

        /// <summary>
        ///     Gets a list of default gateways used by system
        /// </summary>
        /// <returns></returns>
        public static IPAddress[] Gateways
        {
            get
            {
                IEnumerable<NetworkInterface> adapters =
                    NetworkInterface.GetAllNetworkInterfaces().Where(x => x.OperationalStatus == OperationalStatus.Up);
                return adapters.SelectMany(x => x.GetIPProperties().GatewayAddresses.Select(y => y.Address)).ToArray();
            }
        }

        /// <summary>
        ///     Gets a list of default gateways used by system
        /// </summary>
        /// <returns></returns>
        public static IPAddress[] Wins
        {
            get
            {
                IEnumerable<NetworkInterface> adapters =
                    NetworkInterface.GetAllNetworkInterfaces().Where(x => x.OperationalStatus == OperationalStatus.Up);
                return adapters.SelectMany(x => x.GetIPProperties().WinsServersAddresses).ToArray();
            }
        }

        public static IPAddress LocalHost
        {
            get
            {
                return IPAddress.Loopback;
            }
        }
    }
}