using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using Netfluid.Dns.Internals;
using Netfluid.Dns.Serialization;

namespace Netfluid.Dns
{
    public static class DnsClient
    {
        private static readonly Lazy<IPAddress[]> _networkServers = new Lazy<IPAddress[]>(() => NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(x => x.OperationalStatus == OperationalStatus.Up)
            .SelectMany(x => x.GetIPProperties().DnsAddresses)
            .ToArray());


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

        public static IPAddress[] Roots => _roots.Value;


        /// <summary>
        ///     Gets a list of default DNS servers used by system
        /// </summary>
        /// <returns></returns>
        public static IPAddress[] NetworkServers => _networkServers.Value;


        /// <summary>
        ///     Ask a DNS question to a specific server
        /// </summary>
        static Task<IEnumerable<Record>> Query(string name, RecordType qtype, RecordClass qclass = RecordClass.IN, IEnumerable<IPAddress> servers = null)
        {
            if (servers == null)
                servers = NetworkServers;

            var request = new Request {new Question(name, qtype, qclass)};

            return Query(request, servers);
        }

        static async Task<IEnumerable<Record>> Query(Request request, IEnumerable<IPAddress> servers)
        {
            var requestByte = Writer.Serialize(request);

            var client = new UdpClient();
            client.AllowNatTraversal(true);
            client.DontFragment = true;
            client.Client.ReceiveTimeout = 2000;
            client.Client.SendTimeout = 2000;

            for (var intAttempts = 0; intAttempts < 3; intAttempts++)
                foreach (var server in servers)
                    try
                    {
                        await client.SendAsync(requestByte, requestByte.Length, new IPEndPoint(server, 53));
                        var response = await client.ReceiveAsync();

                        return Reader.ReadResponse(response.Buffer).ToArray();
                    }
                    catch (Exception)
                    {
                    }
            return new Response();
        }

        /// <summary>
        ///     Query A records for name into system DNS server
        /// </summary>
        /// <param name="name">domain to query</param>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> A(string name)
        {
            return (await Query(name, RecordType.A)).Select(x => x.ToString());
        }

        /// <summary>
        ///     Query AAAA records for name into system DNS server
        /// </summary>
        /// <param name="name">domain to query</param>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> AAAA(string name)
        {
            return (await Query(name, RecordType.AAAA)).Select(x => x.ToString());
        }

        /// <summary>
        ///     Query CNAME records for name into system DNS server
        /// </summary>
        /// <param name="name">domain to query</param>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> CNAME(string name)
        {
            return (await Query(name, RecordType.CNAME)).Select(x => x.ToString());
        }

        /// <summary>
        ///     Query MX records for name into system DNS server
        /// </summary>
        /// <param name="name">domain to query</param>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> MX(string name)
        {
            return (await Query(name, RecordType.MX)).Select(x => x.ToString());
        }

        /// <summary>
        ///     Query NS records for name into system DNS server
        /// </summary>
        /// <param name="name">domain to query</param>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> NS(string name)
        {
            return (await Query(name, RecordType.NS)).Select(x => x.ToString());
        }

        /// <summary>
        ///     Query PTR records for name into system DNS server
        /// </summary>
        /// <param name="name">domain to query</param>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> PTR(string name)
        {
            return (await Query(name, RecordType.PTR)).Select(x => x.ToString());
        }

        /// <summary>
        ///     Query SOA records for name into system DNS server
        /// </summary>
        /// <param name="name">domain to query</param>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> SOA(string name)
        {
            return (await Query(name, RecordType.SOA)).Select(x => x.ToString());
        }

        /// <summary>
        ///     Query TXT records for name into system DNS server
        /// </summary>
        /// <param name="name">domain to query</param>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> TXT(string name)
        {
            return (await Query(name, RecordType.TXT)).Select(x => x.ToString());
        }
    }
}