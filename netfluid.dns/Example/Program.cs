using System;
using System.Net;
using System.Net.Http.Headers;
using Netfluid.Dns;
using Netfluid.Dns.Interfaces;

namespace Example
{
    internal class Program : IRecordResolver, IExceptionHandler, IAuthority
    {
        private static DnsServer server;

        public Record Resolve(RecordClass recordClass, RecordType type, string name)
        {
            return null;
        }

        private static void Main(string[] args)
        {
            var program = new Program();
            var server = DnsServer.Create("127.0.0.1", 53, program, program, program);
            Console.ReadLine();
        }

        public void OnError(Exception ex)
        {
            Console.WriteLine($"[EXCEPTION] {ex.Message}");
        }

        public bool AreWeAuthority(string name)
        {
            throw new NotImplementedException();
        }
    }
}