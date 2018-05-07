/*
3.3.3. MB RDATA format (EXPERIMENTAL)

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    /                   MADNAME                     /
    /                                               /
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

MADNAME         A <domain-name> which specifies a host which has the
                specified mailbox.

MB records cause additional section processing which looks up an A type
RRs corresponding to MADNAME.
*/

using System;
using Netfluid.Dns.Serialization;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record MB
    /// </summary>
    [Serializable]
    public class RecordMb : Record
    {
        [DomainName] public string MadName;

        public override string ToString()
        {
            return MadName;
        }
    }
}