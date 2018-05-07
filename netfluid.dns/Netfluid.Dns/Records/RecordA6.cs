using System;
using Netfluid.Dns.Serialization;

namespace Netfluid.Dns.Records
{
    //TESTME

    /// <summary>
    ///     DNS record A6 (work in progress)
    /// </summary>
    [Serializable]
    public class RecordA6 : Record
    {
        public byte[] Address;

        [DomainName] public string Dns;

        public byte PrefixSize;

        public override string ToString()
        {
            return "not-used";
        }
    }
}