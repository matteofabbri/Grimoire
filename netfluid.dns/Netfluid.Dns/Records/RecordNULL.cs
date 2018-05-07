/*
3.3.10. NULL RDATA format (EXPERIMENTAL)

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    /                  <anything>                   /
    /                                               /
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

Anything at all may be in the RDATA field so long as it is 65535 octets
or less.

NULL records cause no additional section processing.  NULL RRs are not
allowed in master files.  NULLs are used as placeholders in some
experimental extensions of the DNS.
*/

using System;
using Netfluid.Dns.Internals;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record NULL
    /// </summary>
    [Serializable]
    public class RecordNull : Record
    {
        public byte[] Anything;
        public ushort Lenght;

        public override string ToString()
        {
            return Anything.ToBase64();
        }
    }
}