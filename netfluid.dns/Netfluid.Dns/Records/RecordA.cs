/*
 3.4.1. A RDATA format

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    |                    ADDRESS                    |
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

ADDRESS         A 32 bit Internet address.

Hosts that have multiple Internet addresses will have multiple A
records.
 * 
 */

using System;
using System.Net;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record A
    /// </summary>
    [Serializable]
    public class RecordA : Record
    {
        /// <summary>
        ///     First IPV4 byte
        /// </summary>
        public byte A;

        /// <summary>
        ///     Second IPV4 byte
        /// </summary>
        public byte B;

        /// <summary>
        ///     Third IPV4 byte
        /// </summary>
        public byte C;

        /// <summary>
        ///     Fourth IPV4 byte
        /// </summary>
        public byte D;

        public RecordA()
        {
        }

        public RecordA(IPAddress value)
        {
            var arr = value.GetAddressBytes();
            A = arr[0];
            B = arr[1];
            C = arr[2];
            D = arr[3];
        }

        public RecordA(string s) : this(IPAddress.Parse(s))
        {
        }

        public override string ToString()
        {
            return $"{A}.{B}.{C}.{D}";
        }
    }
}