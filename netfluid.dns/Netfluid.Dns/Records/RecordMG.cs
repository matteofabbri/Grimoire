/*
3.3.6. MG RDATA format (EXPERIMENTAL)

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    /                   MGMNAME                     /
    /                                               /
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

MGMNAME         A <domain-name> which specifies a mailbox which is a
                member of the mail group specified by the domain name.

MG records cause no additional section processing.
*/

using System;
using Netfluid.Dns.Serialization;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record MG
    /// </summary>
    [Serializable]
    public class RecordMg : Record
    {
        [DomainName] public string Mgmname;

        public override string ToString()
        {
            return Mgmname;
        }
    }
}