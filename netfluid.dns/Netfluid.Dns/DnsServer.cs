using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ISocketLite.PCL.EventArgs;
using Netfluid.Dns.Interfaces;
using Netfluid.Dns.Internals;
using SocketLite.Services;
using Netfluid.Dns.Serialization;

namespace Netfluid.Dns
{
    //DNS INTEGRATION, QUERY AND RECORDS FROM http://www.codeproject.com/Articles/23673/DNS-NET-Resolver-C

    /// <summary>
    /// DNS Server and Client
    /// </summary>
    public abstract class DnsServer : IDisposable
    {
        public abstract IRecordResolver RecordResolver { get; set; }

        class UDPServer : DnsServer
        {
            public UdpSocketReceiver udpReceiver;
            public IObservable<IUdpMessage> observerUdpReceiver;
            public IDisposable subscriberUpdReceiver;

            public override IRecordResolver RecordResolver { get; set; }

            public override void Dispose()
            {
                try
                {
                    udpReceiver.Dispose();
                    subscriberUpdReceiver.Dispose();
                }
                catch (Exception)
                {
                }
            }
        }


        public static IEnumerable<Task<DnsServer>> Create(IRecordResolver recordResolver)
        {
            return Network.Interfaces.Select(async x => await Create(x.IpAddress, recordResolver));
        }

        public static Task<DnsServer> Create(string ip, IRecordResolver recordResolver)
        {
            return Create(ip, 53, recordResolver, null, null);
        }

        public static Task<DnsServer> Create(string ip, IRecordResolver recordResolver, IAuthority areWeAuthority, IExceptionHandler onError)
        {
            return Create(ip, 53, recordResolver, areWeAuthority, onError);
        }

        public static async Task<DnsServer> Create(string ip, int port, IRecordResolver recordResolver, IAuthority areWeAuthority, IExceptionHandler onError)
        {
            var networkInterface = Network.Interfaces.FirstOrDefault(x => x.IpAddress == ip);

            var udpReceiver = new UdpSocketReceiver();

            var observerUdpReceiver = await udpReceiver.ObservableUnicastListener(
                port: port,
                communicationInterface: networkInterface,
                allowMultipleBindToSamePort: false);

            var subscriberUpdReceiver = observerUdpReceiver.Subscribe(
                async udpMsg =>
                {
                    var req = Reader.ReadRequest(new MemoryStream(udpMsg.ByteData));
                    var response = new Response(req);

                    foreach (var q in req)
                    {
                        var record = recordResolver.Resolve(q.Class, q.Type, q.Name);
                        if (record == null) continue;

                        if(areWeAuthority?.AreWeAuthority(q.Name) ?? false) response.Authorities.Add(record);
                        else response.Answers.Add(record);
                    }
                    await udpReceiver.SendToAsync(Writer.Serialize(response), udpMsg.RemoteAddress, int.Parse(udpMsg.RemotePort));

                },
                x=> onError?.OnError(x));

            return new UDPServer
            {
                udpReceiver = udpReceiver,
                observerUdpReceiver = observerUdpReceiver,
                subscriberUpdReceiver = subscriberUpdReceiver,
                RecordResolver = recordResolver
            };
        }

        public abstract void Dispose();
    }
}