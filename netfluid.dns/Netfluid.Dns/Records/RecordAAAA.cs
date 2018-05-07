#region Rfc info

/*
2.2 AAAA data format

   A 128 bit IPv6 address is encoded in the data portion of an AAAA
   resource record in network byte order (high-order byte first).
 */

#endregion

using System;
using System.Net;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record AAAA
    /// </summary>
    [Serializable]
    public class RecordAaaa : Record
    {
        public ushort A;
        public ushort B;
        public ushort C;
        public ushort D;
        public ushort E;
        public ushort F;
        public ushort G;
        public ushort H;

        public RecordAaaa()
        {
        }

        public RecordAaaa(string address) : this(IPAddress.Parse(address))
        {
        }

        public RecordAaaa(IPAddress value)
        {
            var arr = value.GetAddressBytes();
            A = arr[0];
            B = arr[1];
            C = arr[2];
            D = arr[3];
            E = arr[4];
            F = arr[5];
            G = arr[6];
            H = arr[7];
        }

        public override string ToString()
        {
            return $"{A:x}:{B:x}:{C:x}:{D:x}:{E:x}:{F:x}:{G:x}:{H:x}";
        }
    }
}