/*
3.3.8. MR RDATA format (EXPERIMENTAL)

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    /                   NEWNAME                     /
    /                                               /
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

NEWNAME         A <domain-name> which specifies a mailbox which is the
                proper rename of the specified mailbox.

MR records cause no additional section processing.  The main use for MR
is as a forwarding entry for a user who has moved to a different
mailbox.
*/

using System;
using Netfluid.Dns.Serialization;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record MR
    /// </summary>
    [Serializable]
    public class RecordMr : Record
    {
        [DomainName] public string Newname;

        public override string ToString()
        {
            return Newname;
        }
    }
}