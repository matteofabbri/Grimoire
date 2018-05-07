using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using ISocketLite.PCL.Interface;
using SocketLite.Model;

namespace Netfluid.Dns
{
    public static class Network
    {
        private static readonly Lazy<CommunicationsInterface> communicationInterface = new Lazy<CommunicationsInterface>(()=> new CommunicationsInterface());
        internal static CommunicationsInterface CommunicationsInterface => communicationInterface.Value;


        private static readonly Lazy<IEnumerable<ICommunicationInterface>> _interfaces = new Lazy<IEnumerable<ICommunicationInterface>>(() => communicationInterface.Value.GetAllInterfaces());
        internal static IEnumerable<ICommunicationInterface> Interfaces => _interfaces.Value;


        private static readonly Lazy<IPAddress[]> _roots = new Lazy<IPAddress[]>(() => new[]
        {
            IPAddress.Parse("198.41.0.4"),
            IPAddress.Parse("192.228.79.201"),
            IPAddress.Parse("192.33.4.12"),
            IPAddress.Parse("199.7.91.13"),
            IPAddress.Parse("192.203.230.10"),
            IPAddress.Parse("192.5.5.241"),
            IPAddress.Parse("192.112.36.4"),
            IPAddress.Parse("128.63.2.53"),
            IPAddress.Parse("192.36.148.17"),
            IPAddress.Parse("192.58.128.30"),
            IPAddress.Parse("193.0.14.129"),
            IPAddress.Parse("198.32.64.12"),
            IPAddress.Parse("202.12.27.33")
        });
        public static IPAddress[] DnsRootServers => _roots.Value;


        private static readonly Lazy<IPAddress[]> _networkServers = new Lazy<IPAddress[]>(() => NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(x => x.OperationalStatus == OperationalStatus.Up)
            .SelectMany(x => x.GetIPProperties().DnsAddresses)
            .ToArray());

        public static IPAddress[] NetworkDnsServers => _networkServers.Value;
    }
}
